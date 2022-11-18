using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Shell
{
    public class DeviceOrganisationInfosViewModel
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public Guid OrganisationId { get; set; }
        public bool Unrestricted { get; set; }
        public string Label { get; set; }
        public Guid? ImageId { get; set; }
        public string ImageBlurHash { get; set; }
        public int? ImageHeight { get; set; }
        public int? ImageWidth { get; set; }
        public string Code { get; set; }
        public List<string> Tags { get; set; }
        public DateTime? LastMaintenance { get; set; }
        public DateTime? NextMaintenance { get; set; }
        public int OperatingHours { get; set; }
        public string SoftwareVersion { get; set; }
        public bool SoftwareUpToDate { get; set; }
        public Guid? ArticleId { get; set; }
        public Guid? LocationId { get; set; }
        public string LocationLabel { get; set; }
        public string LocationAddress { get; set; }
        public Guid? GroupId { get; set; }
        public string GroupLabel { get; set; }
        public Guid? ManagerId { get; set; }
        public string ManagerName { get; set; }
        public Guid ManufacturerId { get; set; }
        public Guid? ModelId { get; set; }
        // public List<ModelStatusInfosViewModel> Statuses { get; set; }
        public List<DeviceStatusViewModel> StatusValues { get; set; }
        public DeviceConnectivityViewModel Connectivity { get; set; }

        #region Translated properties
        public string ArticleLabel { get; set; }
        public string ManufacturerLabel { get; set; }
        public string ModelLabel { get; set; }
        #endregion
    }
}