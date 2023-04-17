using System;
using System.Threading.Tasks;
using System.Collections.Generic;

using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminDeviceFoundationClient
    {
        void Init(IFoundationClient root);
        Task<DeviceDetailsViewModel> UpdateOwner(Guid deviceId, Guid ownerId);
    }
}