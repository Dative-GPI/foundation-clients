using System;
using System.Collections.Generic;

using Foundation.Shared;

namespace Foundation.SourceClients.ViewModels
{
    public class SourceDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Label { get; set; }
        public List<SourceIdentifierInfosViewModel> Identifiers { get; set; }
        public SourceType Type { get; set; }
        public List<DeviceSourceViewModel> DeviceSources { get; set; }
    }
}