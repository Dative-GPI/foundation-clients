using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class SourceDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
        public SourceType Type { get; set; }
        // public List<SourceIdentifierViewModel> Identifiers { get; set; }
        // public List<TranslationSourceViewModel> Translations { get; set; }
    }
}