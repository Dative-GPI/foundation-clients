using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Core;

namespace Foundation.Clients.Abstractions.Core
{
    public interface ICoreModelFoundationClient
    {
        Task<ModelDetailsViewModel> Get(Guid organisationId, Guid modelId);
        Task<IEnumerable<ModelInfosViewModel>> GetAll(Guid organisationId);
        void Init(IFoundationClient root);
    }
}