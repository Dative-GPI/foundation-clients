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
    public class CoreDeviceFoundationClient : ICoreDeviceFoundationClient
    {
        private FoundationClient _root;
        private ILogger<CoreDeviceFoundationClient> _logger;

        private HttpClient _client => _root.CoreClient;

        public CoreDeviceFoundationClient(ILogger<CoreDeviceFoundationClient> logger)
        {
            _logger = logger;
        }

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<DeviceOrganisationInfosViewModel>> GetMany(Guid organisationId, DeviceFilterViewModel filter)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());
            
            Url url = DEVICE_ORGANISATIONS_PATH.SetQueryParams(filter);

            var devices = await _client.GetFromJsonAsync<IEnumerable<DeviceOrganisationInfosViewModel>>(url.ToUri());

            _logger.LogInformation("Receiving {count} devices", devices.Count());

            return devices;
        }

        public async Task<DeviceOrganisationDetailsViewModel> Get(Guid organisationId, Guid deviceId)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());
            
            var device = await _client.GetFromJsonAsync<DeviceOrganisationDetailsViewModel>($"{DEVICE_ORGANISATIONS_PATH}/{deviceId}");

            return device;
        }
    }
}