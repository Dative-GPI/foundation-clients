using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Core
{
    public class DeviceFilterViewModel
    {
        public Guid? LocationId { get; set; }
        public Guid? OtherLocationId { get; set; }
        public Guid? GroupId { get; set; }
        public Guid? OtherGroupId { get; set; }
        public bool? Root { get; set; }
        public bool? IsOwner { get; set; }
        public bool? Unrestricted { get; set; }
        public List<Guid> ModelsIds { get; set; }
        public List<Guid> DeviceOrganisationsIds { get; set; }
        public string Search { get; set; }
    }
}