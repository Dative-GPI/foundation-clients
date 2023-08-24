using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using Flurl;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Admin;
using Foundation.Clients.ViewModels.Admin;

using static Foundation.Clients.Services.AdminFoundationRoutes;

namespace Foundation.Clients.Services
{
    public class AdminDeviceTwinFoundationClient : IAdminDeviceTwinFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;
        

        public async Task<DeviceTwinViewModel> Get(Guid deviceId)
        {
            var twin = await _client.GetFromJsonAsync<DeviceTwinViewModel>($"{DEVICE_TWIN_PATH}/{deviceId}");

            return twin;
        }

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<DeviceTwinViewModel>> GetMany(List<Guid> deviceIds)
        {
            Url url = DEVICE_TWIN_PATH.SetQueryParams(new { DeviceIds = deviceIds });

            var twins = await _client.GetFromJsonAsync<List<DeviceTwinViewModel>>(url.ToUri());

            return twins;
        }

        public async Task Update(Guid deviceId, UpdateDeviceTwinViewModel payload)
        {
            var response = await _client.PatchAsync($"{DEVICE_TWIN_PATH}/{deviceId}", JsonContent.Create(payload));

            response.EnsureSuccessStatusCode();
        }
    }
}