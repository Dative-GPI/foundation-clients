using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Core;

namespace Foundation.Clients.Abstractions.Core
{
    public interface ICoreUserOrganisationFoundationClient
    {
        Task<UserOrganisationDetailsViewModel> Get(Guid organisationId, Guid userOrganisationId);
        Task<IEnumerable<UserOrganisationInfosViewModel>> GetMany(Guid organisationId, UserOrganisationFilterViewModel filter);
        void Init(IFoundationClient root);
    }
}