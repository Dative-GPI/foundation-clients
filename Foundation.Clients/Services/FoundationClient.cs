using System;
using System.Net.Http;

using Foundation.Clients.Abstractions;

namespace Foundation.Clients.Services
{
    public class FoundationClient : IFoundationClient
    {
        public HttpClient FoundationHttpClient { get; }

        public IAdminFoundationClient Admin { get; }
        public ICoreFoundationClient Core { get; }
        public IGatewayFoundationClient Gateway { get; }
        public IDispatcherFoundationClient Dispatcher { get; }

        public FoundationClient(
            HttpClient httpClient,
            IAdminFoundationClient adminFoundationClient,
            ICoreFoundationClient coreFoundationClient,
            IGatewayFoundationClient gatewayFoundationClient,
            IDispatcherFoundationClient dispatcherFoundationClient
        )
        {
            FoundationHttpClient = httpClient;

            Admin = adminFoundationClient;
            Core = coreFoundationClient;
            Gateway = gatewayFoundationClient;
            Dispatcher = dispatcherFoundationClient;
        }

        public void Init(string host, string languageCode, string jwt = null)
        {
            FoundationHttpClient.BaseAddress = new Uri($"https://{host}");
            
            if (!String.IsNullOrWhiteSpace(jwt))
            {
                FoundationHttpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
            }

            if (!String.IsNullOrEmpty(languageCode))
            {
                FoundationHttpClient.DefaultRequestHeaders.Add("Accept-Language", languageCode);
            }

            Admin.Init(this);
            Core.Init(this);
            Gateway.Init(this);
            Dispatcher.Init(this);
        }
    }
}