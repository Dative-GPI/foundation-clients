using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;
using Flurl;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Core;
using Foundation.Clients.ViewModels.Core;

using static Foundation.Clients.Services.CoreFoundationRoutes;
using Foundation.Clients.Extensions;

namespace Foundation.Clients.Services
{
    public class CoreOrganisationFoundationClient : ICoreOrganisationFoundationClient
    {
        private FoundationClient _root;
        private ILogger<CoreOrganisationFoundationClient> _logger;

        private HttpClient _client => _root.FoundationHttpClient;

        public CoreOrganisationFoundationClient(ILogger<CoreOrganisationFoundationClient> logger)
        {
            _logger = logger;
        }

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<OrganisationInfosViewModel>> GetMany(Guid organisationId, OrganisationFilterViewModel filter)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());

            Url url = ORGANISATIONS_PATH.SetQueryParams(filter);
            
            var organisations = await _client.GetFromJsonAsync<IEnumerable<OrganisationInfosViewModel>>(url.ToUri());

            _logger.LogInformation("Receiving {count} organisations", organisations.Count());

            return organisations;
        }

        public async Task<OrganisationDetailsViewModel> Get(Guid organisationId)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());
            
            var organisation = await _client.GetFromJsonAsync<OrganisationDetailsViewModel>($"{ORGANISATIONS_PATH}/{organisationId}");

            _logger.LogInformation("Receiving organisation {organisationId}", organisationId);

            return organisation;
        }
    }
}