using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class CreateDeviceOrganisationViewModel
    {
        public Guid OrganisationId { get; set; }
        public Guid DeviceId { get; set; }
        public bool Unrestricted { get; set; }
        public string Label { get; set; }
        public string Description { get; set; }
        public List<string> Tags { get; set; }
        public byte[] Image { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? ManagerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? WarrantyEndDate { get; set; }
        public DateTime? WarrantyStartDate { get; set; }
        public bool Disabled { get; set; }
    }
}