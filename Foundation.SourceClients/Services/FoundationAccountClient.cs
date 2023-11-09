using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using System.Net.Http;
using System.Net.Http.Json;
using System.Net.WebSockets;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

using Microsoft.Extensions.Logging;

using Foundation.SourceClients.Abstractions;

using static Foundation.SourceClients.Services.FoundationRoutes;

namespace Foundation.SourceClients.Services
{
    public class FoundationAccountClient : IFoundationAccountClient
    {
        private ILogger<FoundationAccountClient> _logger;
        private FoundationClient _root;
        private HttpClient _client => _root.SourceClient;

        public FoundationAccountClient(
            ILogger<FoundationAccountClient> logger
        )
        {
            _logger = logger;
        }

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }


        public async Task<X509Certificate2> Create(string token, string machineId, CancellationToken ct)
        {
            _logger.LogInformation(
                "Acquiring credential with token {token} on {uri}",
                token, _client.BaseAddress + ACCOUNT_PATH
            );

            var response = await _client.PostAsJsonAsync(ACCOUNT_PATH, new { Token = token, MachineId = machineId }, cancellationToken: ct);
            response.EnsureSuccessStatusCode();

            var payload = await response.Content.ReadFromJsonAsync<CredentialPayload>(cancellationToken: ct);
            var secret = Convert.FromBase64String(payload.Secret);

            var certificate = new X509Certificate2(secret);

            return certificate;
        }

        public async Task<string> Login(X509Certificate2 certificate, CancellationToken ct)
        {
            Memory<byte> buffer = new Memory<byte>(new byte[4 * 1024]);

            var client = new ClientWebSocket();
            client.Options.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;

            await Connect(client, ct);
            await SendPublicKey(client, certificate, ct);
            var payload = await ReceivePayloadToSign(client, buffer, ct);
            var signedData = SignPayload(certificate, payload);
            await SendSignedPayload(client, signedData, ct);
            var token = await ReceiveBearerToken(client, buffer, ct);

            _logger.LogInformation("Token acquired {token}", token);

            await client.CloseAsync(WebSocketCloseStatus.NormalClosure, null, ct);

            return token;
        }


        private async Task Connect(ClientWebSocket client, CancellationToken ct)
        {
            var baseAddress = new UriBuilder(_client.BaseAddress);
            baseAddress.Scheme = "wss://";

            var uri = new Uri(baseAddress.Uri, LOGIN_PATH);

            _logger.LogInformation("[Login] Connecting to {uri}", uri);

            await client.ConnectAsync(uri, ct);
        }

        private async Task SendPublicKey(ClientWebSocket client, X509Certificate2 certificate, CancellationToken ct)
        {
            _logger.LogDebug("[Login] Sending certificate");

            await client.SendAsync(
                certificate.Export(X509ContentType.Cert), // on n'exporte que la clé publique
                WebSocketMessageType.Binary,
                true,
                ct
            );
        }
        private async Task<byte[]> ReceivePayloadToSign(ClientWebSocket client, Memory<byte> buffer, CancellationToken ct)
        {
            _logger.LogDebug("[Login] Waiting for payload to sign");

            var response = await client.ReceiveAsync(buffer, ct);
            return buffer.Slice(0, response.Count).ToArray();
        }

        private byte[] SignPayload(X509Certificate2 certificate, byte[] payload)
        {
            _logger.LogDebug("[Login] Signing payload with certificate");

            var csp = certificate.GetRSAPrivateKey();

            var signedData = csp.SignData(
                payload,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1
            );
            return signedData;
        }

        private async Task SendSignedPayload(ClientWebSocket client, byte[] signedData, CancellationToken ct) { 
            _logger.LogDebug("[Login] Sending signed payload");

            await client.SendAsync(signedData, WebSocketMessageType.Binary, true, ct);
        }

        private async Task<string> ReceiveBearerToken(ClientWebSocket client, Memory<byte> buffer, CancellationToken ct) {
            _logger.LogDebug("[Login] Waiting for bearer token");

            var response = await client.ReceiveAsync(buffer, ct);
            var token = Encoding.UTF8.GetString(buffer.Slice(0, response.Count).ToArray());

            return token;
        }

        public async Task<X509Certificate2> RenewCertificate(CancellationToken ct)
        {
            _logger.LogInformation(
                "Renewing credential on {uri}",
                _client.BaseAddress + RENEW_PATH
            );

            var response = await _client.PostAsJsonAsync(RENEW_PATH, ct);
            response.EnsureSuccessStatusCode();

            var payload = await response.Content.ReadFromJsonAsync<CredentialPayload>(cancellationToken: ct);
            var secret = Convert.FromBase64String(payload.Secret);

            var certificate = new X509Certificate2(secret);

            return certificate;
        }
    }

    public class CredentialPayload
    {
        public string Secret { get; set; }
    }
}