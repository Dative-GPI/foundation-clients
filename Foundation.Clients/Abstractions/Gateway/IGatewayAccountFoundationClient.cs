using System.Threading.Tasks;

namespace Foundation.Clients.Abstractions.Gateway
{
    public interface IGatewayAccountFoundationClient
    {
        void Init(IFoundationClient root);
        Task<bool> IsAuthenticated();
    }
}