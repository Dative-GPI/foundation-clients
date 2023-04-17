using System;
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
    public class AdminDeviceFoundationClient : IAdminDeviceFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.AdminClient;

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<DeviceDetailsViewModel> UpdateOwner(Guid deviceId, Guid ownerId)
        {
            var response = await _client.PostAsJsonAsync(DEVICE_ORGANISATION_PATH.AppendPathSegments(deviceId, "owner"), new { OwnerId = ownerId });

            response.EnsureSuccessStatusCode();

            return await response.Content.ReadFromJsonAsync<DeviceDetailsViewModel>();
        }
    }
}