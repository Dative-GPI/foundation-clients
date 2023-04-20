using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using Flurl;

using Foundation.Clients.Abstractions;
using Foundation.Clients.ViewModels.Admin;

using static Foundation.Clients.Services.AdminFoundationRoutes;

namespace Foundation.Clients.Services
{
    public class AdminOrganisationFoundationClient : IAdminOrganisationFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.AdminClient;

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public Task BulkUpsert(List<UpsertOrganisationViewModel> payload)
        {
            throw new NotImplementedException();
        }

        public async Task<OrganisationDetailsViewModel> Create(CreateOrganisationViewModel payload)
        {
            var response = await _client.PostAsJsonAsync(ORGANISATION_PATH, payload);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<OrganisationDetailsViewModel>();
        }

        public Task<OrganisationDetailsViewModel> Get(Guid organisationId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrganisationInfosViewModel>> GetMany(OrganisationFilterViewModel filter)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid organisationId)
        {
            throw new NotImplementedException();
        }

        public Task SendAdminInvitation(Guid organisationId)
        {
            throw new NotImplementedException();
        }

        public Task<OrganisationDetailsViewModel> Update(Guid organisationId, UpdateOrganisationViewModel payload)
        {
            throw new NotImplementedException();
        }

        public async Task<OrganisationDetailsViewModel> UpdateAdmin(Guid organisationId, UpdateOrganisationAdminViewModel payload)
        {
            var response = await _client.PostAsJsonAsync(ORGANISATION_PATH.AppendPathSegments(organisationId).AppendPathSegment("admin"), payload);

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<OrganisationDetailsViewModel>();
        }
    }
}