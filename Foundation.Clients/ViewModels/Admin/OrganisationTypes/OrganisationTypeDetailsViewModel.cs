using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class OrganisationTypeDetailsViewModel
    {
        public Guid Id { get; set; }
        public Guid ApplicationId { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public List<TranslationOrganisationTypeViewModel> Translations { get; set; }
    }
}