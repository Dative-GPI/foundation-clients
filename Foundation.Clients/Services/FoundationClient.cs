using System;
using System.Net.Http;

using Foundation.Clients.Abstractions;

namespace Foundation.Clients.Services
{
    public class FoundationClient : IFoundationClient
    {
        public HttpClient AdminClient { get; }
        public HttpClient CoreClient { get; }
        public HttpClient GatewayClient { get; }
        public HttpClient DispatcherClient { get; }

        public IAdminFoundationClient Admin { get; }
        public ICoreFoundationClient Core { get; }
        public IGatewayFoundationClient Gateway { get; }
        public IDispatcherFoundationClient Dispatcher { get; }

        public FoundationClient(
            HttpClient adminClient,
            HttpClient shellClient,
            HttpClient gatewayClient,
            HttpClient dispatcherClient,
            IAdminFoundationClient adminFoundationClient,
            ICoreFoundationClient shellFoundationClient,
            IGatewayFoundationClient gatewayFoundationClient,
            IDispatcherFoundationClient dispatcherFoundationClient
        )
        {
            AdminClient = adminClient;
            CoreClient = shellClient;
            GatewayClient = gatewayClient;
            DispatcherClient = dispatcherClient;

            Admin = adminFoundationClient;
            Core = shellFoundationClient;
            Gateway = gatewayFoundationClient;
            Dispatcher = dispatcherFoundationClient;
        }

        public void Init(string adminHost, string shellHost, string languageCode, string jwt = null)
        {
            AdminClient.BaseAddress = new Uri($"https://{adminHost}");
            CoreClient.BaseAddress = new Uri($"https://{shellHost}");
            GatewayClient.BaseAddress = new Uri($"https://{shellHost}");
            DispatcherClient.BaseAddress = new Uri($"https://{adminHost}");

            if (!String.IsNullOrWhiteSpace(jwt))
            {
                CoreClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
                GatewayClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
                AdminClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
                DispatcherClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
            }

            if (!String.IsNullOrEmpty(languageCode))
            {
                AdminClient.DefaultRequestHeaders.Add("Accept-Language", languageCode);
                CoreClient.DefaultRequestHeaders.Add("Accept-Language", languageCode);
                GatewayClient.DefaultRequestHeaders.Add("Accept-Language", languageCode);
                DispatcherClient.DefaultRequestHeaders.Add("Accept-Language", languageCode);
            }

            Admin.Init(this);
            Core.Init(this);
            Gateway.Init(this);
            Dispatcher.Init(this);
        }
    }
}