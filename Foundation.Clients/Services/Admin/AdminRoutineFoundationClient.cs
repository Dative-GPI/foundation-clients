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
    public class AdminRoutineFoundationClient : IAdminRoutineFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;


        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<RoutineDetailsViewModel> Get(Guid routineId)
        {
            Url url = $"{ROUTINES_PATH}/{routineId}";

            var routine = await _client.GetFromJsonAsync<RoutineDetailsViewModel>(url.ToUri());

            return routine;
        }

        public async Task<IEnumerable<RoutineInfosViewModel>> GetMany(RoutineFilter filter)
        {
            Url url = ROUTINES_PATH.SetQueryParams(filter);

            var routines = await _client.GetFromJsonAsync<List<RoutineInfosViewModel>>(url.ToUri());

            return routines;
        }
    }
}