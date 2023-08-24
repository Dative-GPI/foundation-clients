using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using Flurl;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Dispatcher;
using Foundation.Clients.ViewModels.Dispatcher;

using static Foundation.Clients.Services.DispatcherFoundationRoutes;

namespace Foundation.Clients.Services
{
    public class DispatcherRoutineFoundationClient : IDispatcherRoutineFoundationClient
    {
        private FoundationClient _root;

        private HttpClient _client => _root.FoundationHttpClient;


        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<RoutineExecutionDetailsViewModel> Send(Guid routineId, SendRoutineViewModel payload)
        {
            Url url = $"{ROUTINES_PATH}/{routineId}/send";

            var response = await _client.PostAsJsonAsync(url.ToUri(), payload);
            response.EnsureSuccessStatusCode();
            var execution = await response.Content.ReadFromJsonAsync<RoutineExecutionDetailsViewModel>();

            return execution;
        }
    }
}