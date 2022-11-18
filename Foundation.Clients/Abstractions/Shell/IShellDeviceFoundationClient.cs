using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Shell;

namespace Foundation.Clients.Abstractions.Shell
{
    public interface IShellDeviceFoundationClient
    {
        Task<DeviceOrganisationDetailsViewModel> Get(Guid organisationId, Guid deviceId);
        Task<IEnumerable<DeviceOrganisationInfosViewModel>> GetMany(Guid organisationId, DeviceFilterViewModel filter);
        void Init(IFoundationClient root);
    }
}