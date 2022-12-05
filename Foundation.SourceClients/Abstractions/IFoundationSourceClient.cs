using System.Threading.Tasks;

using Foundation.SourceClients.ViewModels;

namespace Foundation.SourceClients.Abstractions
{
    public interface IFoundationSourceClient
    {
        void Init(IFoundationClient root);
        Task<SourceDetailsViewModel> GetCurrent();
    }
}