using System;
using System.Net.Http;

using Foundation.SourceClients.Abstractions;

namespace Foundation.SourceClients.Services
{
    public class FoundationClient : IFoundationClient
    {
        public HttpClient SourceClient { get; }
        public IFoundationAccountClient Account { get; }

        public FoundationClient(
            HttpClient sourceClient,
            IFoundationAccountClient foundationAccountClient
        )
        {
            SourceClient = sourceClient;
            Account = foundationAccountClient;
        }

        public void Init(string uri, string languageCode, string jwt = null)
        {
            SourceClient.BaseAddress = new Uri(uri);

            if (!String.IsNullOrWhiteSpace(jwt))
            {
                SourceClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {jwt}");
            }

            if (!String.IsNullOrWhiteSpace(languageCode))
            {
                SourceClient.DefaultRequestHeaders.Add("Accept-Language", languageCode);
            }

            Account.Init(this);
        }
    }
}