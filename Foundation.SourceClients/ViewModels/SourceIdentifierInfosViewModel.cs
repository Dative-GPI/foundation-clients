using System;

using Foundation.Shared;

namespace Foundation.SourceClients.ViewModels
{
    public class SourceIdentifierInfosViewModel
    {
        public Guid Id { get; set; }
        public string Identifier { get; set; }
        public DateTime DateMin { get; set; }
        public DateTime DateMax { get; set; }
        public SecretType Type { get; set; }
    }
}