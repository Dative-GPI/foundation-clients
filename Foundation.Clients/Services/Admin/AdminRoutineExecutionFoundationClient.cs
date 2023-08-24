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
    public class AdminRoutineExecutionFoundationClient : IAdminRoutineExecutionFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;


        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<RoutineExecutionDetailsViewModel> Get(Guid routineId, Guid executionId)
        {
            Url url = $"{ROUTINES_PATH}/{routineId}/executions/{executionId}";

            var execution = await _client.GetFromJsonAsync<RoutineExecutionDetailsViewModel>(url.ToUri());

            return execution;
        }

        public async Task<IEnumerable<RoutineExecutionInfosViewModel>> GetMany(Guid routineId, RoutineExecutionFilter filter)
        {
            Url url = $"{ROUTINES_PATH}/{routineId}/executions".SetQueryParams(filter);

            var executions = await _client.GetFromJsonAsync<List<RoutineExecutionInfosViewModel>>(url.ToUri());

            return executions;
        }
    }
}