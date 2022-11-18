using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Shell;

namespace Foundation.Clients.Abstractions.Shell
{
    public interface IShellModelFoundationClient
    {
        Task<ModelDetailsViewModel> Get(Guid organisationId, Guid modelId);
        Task<IEnumerable<ModelInfosViewModel>> GetAll(Guid organisationId);
        void Init(IFoundationClient root);
    }
}