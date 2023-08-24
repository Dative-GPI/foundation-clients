using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using Flurl;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Admin;
using Foundation.Clients.ViewModels.Admin;

using static Foundation.Clients.Services.AdminFoundationRoutes;

namespace Foundation.Clients.Services
{
    public class AdminSourceFoundationClient : IAdminSourceFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;


        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<SourceDetailsViewModel> Get(Guid sourceId)
        {
            Url url = $"{SOURCES_PATH}/{sourceId}";

            var source = await _client.GetFromJsonAsync<SourceDetailsViewModel>(url.ToUri());

            return source;
        }

        public async Task<IEnumerable<SourceInfosViewModel>> GetMany(SourceFilter filter)
        {
            Url url = SOURCES_PATH.SetQueryParams(filter);

            var sources = await _client.GetFromJsonAsync<List<SourceInfosViewModel>>(url.ToUri());

            return sources;
        }
    }
}