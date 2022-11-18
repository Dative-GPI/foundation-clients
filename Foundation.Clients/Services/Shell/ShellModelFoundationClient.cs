using System;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Shell;
using Foundation.Clients.ViewModels.Shell;

using static Foundation.Clients.Services.ShellFoundationRoutes;
using Foundation.Clients.Extensions;

namespace Foundation.Clients.Services
{
    public class ShellModelFoundationClient : IShellModelFoundationClient
    {
        private FoundationClient _root;
        private ILogger<ShellModelFoundationClient> _logger;

        private HttpClient _client => _root.ShellClient;

        public ShellModelFoundationClient(ILogger<ShellModelFoundationClient> logger)
        {
            _logger = logger;
        }

        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }

        public async Task<IEnumerable<ModelInfosViewModel>> GetAll(Guid organisationId)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());

            var models = await _client.GetFromJsonAsync<IEnumerable<ModelInfosViewModel>>(MODELS_PATH);

            _logger.LogInformation("Receiving {count} models", models.Count());

            return models;
        }

        public async Task<ModelDetailsViewModel> Get(Guid organisationId, Guid modelId)
        {
            _client.DefaultRequestHeaders.Set("X-Organisation-Id", organisationId.ToString());
            
            var model = await _client.GetFromJsonAsync<ModelDetailsViewModel>($"{MODELS_PATH}/{modelId}");

            return model;
        }
    }
}