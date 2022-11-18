using System;

namespace Foundation.SourceClients.Abstractions
{
    public interface IFoundationClient
    {
        void Init(string uri, string languageCode = null, string jwt = null);
        IFoundationAccountClient Account { get; }
    }
}