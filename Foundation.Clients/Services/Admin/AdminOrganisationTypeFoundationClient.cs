using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using Flurl;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Admin;
using Foundation.Clients.ViewModels.Admin;

using static Foundation.Clients.Services.AdminFoundationRoutes;

namespace Foundation.Clients.Services
{
    public class AdminOrganisationTypeFoundationClient : IAdminOrganisationTypeFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public Task<OrganisationTypeDetailsViewModel> Create(CreateOrganisationTypeViewModel payload)
        {
            throw new NotImplementedException();
        }

        public Task<OrganisationTypeDetailsViewModel> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OrganisationTypeInfosViewModel>> GetMany(OrganisationTypeFilterViewModel filter)
        {
            Url url = ORGANISATION_TYPE_PATH.SetQueryParams(filter);

            var organisations = await _client.GetFromJsonAsync<List<OrganisationTypeInfosViewModel>>(url.ToUri());

            return organisations;
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<OrganisationTypeDetailsViewModel> Update(Guid organisationTypeId, UpdateOrganisationTypeViewModel payload)
        {
            throw new NotImplementedException();
        }
    }
}