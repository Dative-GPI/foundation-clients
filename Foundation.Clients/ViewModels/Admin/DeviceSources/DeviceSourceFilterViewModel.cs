using System;

namespace Foundation.Clients.ViewModels.Admin
{
    public class DeviceSourcesFilterViewModel
    {
        public Guid? DeviceId { get; set; }
        public Guid? SourceId { get; set; }
        public string MachineId { get; set; }
    }
}