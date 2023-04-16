using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class CreateDeviceViewModel
    {
        public string Code { get; set; }
        public Guid? ArticleId { get; set; }
        public Guid? ModelId { get; set; }
        public Guid ManufacturerId { get; set; }
        public Dictionary<string, string> Meta { get; set; }
        public DateTime? LastMaintenance { get; set; }
        public DateTime? NextMaintenance { get; set; }
        public int OperatingHours { get; set; }
        public List<DeviceOptionViewModel> Options { get; set; }
        public Guid? OwnerId { get; set; }
        public bool SoftwareUpToDate { get; set; }
        public string SoftwareVersion { get; set; }
        public byte[] Image { get; set; }
    }
}