using System;
using System.Collections.Generic;
using Foundation.Domain.Shared;

namespace Foundation.Clients.ViewModels.Admin
{
    public class OrganisationDetailsViewModel
    {
        public Guid Id { get; set; }
        public Guid? ImageId { get; set; }
        public int ImageWidth { get; set; }
        public int ImageHeight { get; set; }
        public string ImageBlurHash { get; set; }
        public Guid OrganisationTypeId { get; set; }
        public string OrganisationTypeLabel { get; set; }
        public Guid? AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPhoneNumber { get; set; }
        public string AdminLanguageCode { get; set; }
        public string AdminLanguageLabel { get; set; }
        public Guid? MainDashboardId { get; set; }
        public int UserCount { get; set; }
        public int LocationCount { get; set; }
        public int DeviceCount { get; set; }
        public List<Guid> UsersIds { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
        public UserValidityState? AdminValidity { get; set; }
        public List<TranslationOrganisationViewModel> Translations{ get; set; }
    }
}