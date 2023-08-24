using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Core;

namespace Foundation.Clients.Abstractions.Core
{
    public interface ICorePermissionFoundationClient
    {
        void Init(IFoundationClient root);
        Task<IEnumerable<PermissionInfosViewModel>> GetMany(Guid organisationId);
    }
}