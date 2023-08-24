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
    public class AdminDeviceSourceFoundationClient : IAdminDeviceSourceFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;


        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<DeviceSourceViewModel>> GetMany(DeviceSourcesFilterViewModel filter)
        {
            Url url = DEVICE_SOURCES_PATH.SetQueryParams(filter);

            var deviceSources = await _client.GetFromJsonAsync<List<DeviceSourceViewModel>>(url.ToUri());

            return deviceSources;
        }
    }
}