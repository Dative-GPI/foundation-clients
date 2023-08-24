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
    public class CorePermissionFoundationClient : ICorePermissionFoundationClient
    {
        private FoundationClient _root;
        private ILogger<CorePermissionFoundationClient> _logger;

        private HttpClient _client => _root.FoundationHttpClient;

        public CorePermissionFoundationClient(ILogger<CorePermissionFoundationClient> logger)
        {
            _logger = logger;
        }

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<PermissionInfosViewModel>> GetMany(Guid organisationId)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());
            
            Url url = PERMISSIONS_PATH;

            var permissions = await _client.GetFromJsonAsync<List<PermissionInfosViewModel>>(url.ToUri());

            _logger.LogInformation("Receiving {count} permissions", permissions.Count());

            return permissions;
        }
    }
}