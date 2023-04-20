using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions
{
    public interface IAdminOrganisationFoundationClient
    {
        void Init(IFoundationClient root);

        Task<OrganisationDetailsViewModel> Get(Guid organisationId);
        Task<IEnumerable<OrganisationInfosViewModel>> GetMany(OrganisationFilterViewModel filter);
        Task<OrganisationDetailsViewModel> Create(CreateOrganisationViewModel payload);
        Task<OrganisationDetailsViewModel> Update(Guid organisationId, UpdateOrganisationViewModel payload);
        Task BulkUpsert(List<UpsertOrganisationViewModel> payload);
        Task Remove(Guid organisationId);
        
        Task<OrganisationDetailsViewModel> UpdateAdmin(Guid organisationId, UpdateOrganisationAdminViewModel payload);
        Task SendAdminInvitation(Guid organisationId);
    }
}