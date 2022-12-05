using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Foundation.SourceClients.Abstractions;
using Foundation.SourceClients.ViewModels;
using static Foundation.SourceClients.Services.FoundationRoutes;

namespace Foundation.SourceClients.Services
{
    public class FoundationSourceClient : IFoundationSourceClient
    {
        private FoundationClient _root;
        private HttpClient _client => _root.SourceClient;
        
        public void Init(IFoundationClient root)
        {
            _root = (FoundationClient)root;
        }
        
        public async Task<SourceDetailsViewModel> GetCurrent()
        {
            var url = $"{SOURCE_PATH}/current";
            
            var organisations = await _client.GetFromJsonAsync<SourceDetailsViewModel>(url);
            
            return organisations;
        }

    }
}