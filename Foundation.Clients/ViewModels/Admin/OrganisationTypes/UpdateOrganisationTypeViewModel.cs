using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpdateOrganisationTypeViewModel
    {
        public string Code { get; set; }
        public string LabelDefault { get; set; }
        public string DescriptionDefault { get; set; }
        public List<TranslationOrganisationTypeViewModel> Translations { get; set; }
    }
}