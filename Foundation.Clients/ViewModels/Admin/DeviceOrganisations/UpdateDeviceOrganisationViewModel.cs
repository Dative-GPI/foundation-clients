using System;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpdateDeviceOrganisationViewModel
    {
        public string Label { get; set; }
        public string Description { get; set; }
        public Guid? ImageId { get; set; }
        public byte[] Image { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? GroupId { get; set; }
        public bool Unrestricted { get; set; }
        public bool Disabled { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
    }
}