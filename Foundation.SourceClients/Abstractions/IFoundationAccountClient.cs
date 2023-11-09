using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Foundation.SourceClients.Abstractions
{
    public interface IFoundationAccountClient
    {
        void Init(IFoundationClient root);
        
        Task<X509Certificate2> Create(string token, string machineId = null, CancellationToken ct = default(CancellationToken));
        Task<string> Login(X509Certificate2 certificate, CancellationToken ct);
        Task<X509Certificate2> RenewCertificate(CancellationToken ct);
    }
}