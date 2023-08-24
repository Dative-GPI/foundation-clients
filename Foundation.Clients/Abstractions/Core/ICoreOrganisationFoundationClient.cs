using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Core;

namespace Foundation.Clients.Abstractions.Core
{
    public interface ICoreOrganisationFoundationClient
    {
        Task<OrganisationDetailsViewModel> Get(Guid organisationId);
        Task<IEnumerable<OrganisationInfosViewModel>> GetMany(Guid organisationId, OrganisationFilterViewModel filter);
        void Init(IFoundationClient root);
    }
}