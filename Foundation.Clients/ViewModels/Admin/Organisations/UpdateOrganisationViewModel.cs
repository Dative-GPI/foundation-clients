using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpdateOrganisationViewModel
    {
        public string Code { get; set; }
        public Guid? ImageId { get; set; }
        public byte[] Image { get; set; }
        public string LabelDefault { get; set; }
        public string DescriptionDefault { get; set; }
        public List<TranslationOrganisationViewModel> Translations { get; set; }
    }
}