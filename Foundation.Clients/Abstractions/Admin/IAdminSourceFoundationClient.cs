using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminSourceFoundationClient
    {
        void Init(IFoundationClient root);
        Task<SourceDetailsViewModel> Get(Guid sourceId);
        Task<IEnumerable<SourceInfosViewModel>> GetMany(SourceFilter filter);
    }
}