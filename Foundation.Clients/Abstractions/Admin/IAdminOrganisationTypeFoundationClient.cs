using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminOrganisationTypeFoundationClient
    {
        void Init(IFoundationClient root);
        
        Task<OrganisationTypeDetailsViewModel> Create(CreateOrganisationTypeViewModel payload);
        Task<OrganisationTypeDetailsViewModel> Update(Guid organisationTypeId, UpdateOrganisationTypeViewModel payload);
        Task Remove(Guid id);
        Task<OrganisationTypeDetailsViewModel> Get(Guid id);
        Task<IEnumerable<OrganisationTypeInfosViewModel>> GetMany(OrganisationTypeFilterViewModel filter);
    }
}