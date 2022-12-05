using System;

namespace Foundation.SourceClients.ViewModels
{
    public class DeviceSourceViewModel
    {
        public Guid Id { get; set; }
        public Guid DeviceId { get; set; }
        public string DeviceCode { get; set; }
        public Guid? DeviceOwnerId { get; set; }
        public string DeviceOwnerLabel { get; set; }
        public string MachineId { get; set; }
        public string Label { get; set; }
    }
}