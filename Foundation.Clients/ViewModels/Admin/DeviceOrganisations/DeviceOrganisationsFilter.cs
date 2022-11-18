using System;
using System.Collections.Generic;

namespace Foundation.Clients.ViewModels.Admin
{
    public class DeviceOrganisationsFilter
    {
        public Guid? DeviceId { get; set; }
        public Guid? OrganisationId { get; set; }
        public string Search { get; set; }
        public List<Guid> DeviceOrganisationIds { get; set; }
    }
}