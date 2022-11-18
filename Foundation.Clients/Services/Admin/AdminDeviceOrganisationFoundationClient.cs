using System.Linq;
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
    public class AdminDeviceOrganisationFoundationClient : IAdminDeviceOrganisationFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.AdminClient;


        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<DeviceOrganisationInfosViewModel>> GetMany(DeviceOrganisationsFilter filter)
        {
            if (filter.DeviceOrganisationIds != null && !filter.DeviceOrganisationIds.Any())
            {
                return Enumerable.Empty<DeviceOrganisationInfosViewModel>();
            }

            Url url = DEVICE_ORGANISATION_PATH.SetQueryParams(filter);

            var organisations = await _client.GetFromJsonAsync<List<DeviceOrganisationInfosViewModel>>(url.ToUri());

            return organisations;
        }
    }
}