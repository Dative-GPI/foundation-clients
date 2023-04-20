using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpsertOrganisationViewModel
    {
        public string Code { get; set; }
        public string LabelDefault { get; set; }
        public string DescriptionDefault { get; set; }

        public string OrganisationTypeCode { get; set; }

        public List<UpsertOrganisationTranslationViewModel> Translations { get; set; }
    }

    public class UpsertOrganisationTranslationViewModel
    {
        public string LanguageCode { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
    }
}