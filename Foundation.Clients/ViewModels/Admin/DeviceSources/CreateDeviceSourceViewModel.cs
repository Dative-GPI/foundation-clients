using System;

namespace Foundation.Clients.ViewModels.Admin
{
    public class CreateDeviceSourceViewModel
    {
        public Guid DeviceId { get; set; }
        public Guid SourceId { get; set; }
        public string MachineId { get; set; }
        public string Label { get; set; }
    }
}