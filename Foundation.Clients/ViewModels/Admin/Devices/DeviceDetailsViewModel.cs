using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class DeviceDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public Guid? ImageId { get; set; }
        public string ImageBlurHash { get; set; }
        public int? ImageHeight { get; set; }
        public int? ImageWidth { get; set; }
        public DateTime? LastMaintenance { get; set; }
        public DateTime? NextMaintenance { get; set; }
        public int OperatingHours { get; set; }
        public string SoftwareVersion { get; set; }
        public bool SoftwareUpToDate { get; set; }
        public Guid? ArticleId { get; set; }
        public string ArticleCode { get; set; }
        public Guid ManufacturerId { get; set; }
        public Guid? ModelId { get; set; }
        public Guid? OwnerId { get; set; }
        public string OwnerLabel { get; set; }
        public string OwnerCode { get; set; }
        public Guid? FamilyId { get; set; }
        public List<DeviceOptionViewModel> Options { get; set; }
        public Dictionary<string, string> Meta { get; set; }

        #region Translated properties
        public string ArticleLabel { get; set; }
        public string ManufacturerLabel { get; set; }
        public string FamilyLabel { get; set; }
        public string ModelLabel { get; set; }
        #endregion
    }
}