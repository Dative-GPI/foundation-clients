using System;
using System.Collections.Generic;

using Foundation.Shared;

namespace Foundation.Clients.ViewModels.Admin
{
    public class OrganisationInfosViewModel
    {
        public Guid Id { get; set; }
        public int UserCount { get; set; }
        public int DeviceCount { get; set; }
        public string OrganisationTypeCode { get; set; }
        public Guid OrganisationTypeId { get; set; }
        public string Label { get; set; }
        public string AdminEmail { get; set; }
        public string Code { get; set; }
        public UserValidityState? AdminValidity { get; set; }
        public List<TranslationOrganisationViewModel> Translations { get; set; }
    }
}