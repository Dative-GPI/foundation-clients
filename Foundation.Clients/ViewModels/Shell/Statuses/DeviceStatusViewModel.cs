using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Shell
{
    public class DeviceStatusViewModel
    {
        public int Index { get; set; }
        public Guid? GroupById { get; set; }
        public string GroupByLabel { get; set; }
        public List<DeviceStatusGroupViewModel> StatusGroups { get; set; }
    }

    public class DeviceStatusGroupViewModel
    {
        public string GroupByValue { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
    }
}