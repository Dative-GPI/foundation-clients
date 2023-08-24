using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.ViewModels.Core;

namespace Foundation.Clients.Abstractions.Core
{
    public interface ICoreDeviceFoundationClient
    {
        Task<DeviceOrganisationDetailsViewModel> Get(Guid organisationId, Guid deviceId);
        Task<IEnumerable<DeviceOrganisationInfosViewModel>> GetMany(Guid organisationId, DeviceFilterViewModel filter);
        void Init(IFoundationClient root);
    }
}