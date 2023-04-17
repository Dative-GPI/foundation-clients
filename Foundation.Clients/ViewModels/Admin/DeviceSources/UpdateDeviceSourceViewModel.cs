using System;

namespace Foundation.Clients.ViewModels.Admin
{
    public class UpdateDeviceSourceViewModel
    {
        public Guid SourceId { get; set; }
        public Guid DeviceId { get; set; }
        public string MachineId { get; set; }
        public string Label { get; set; }
    }
}