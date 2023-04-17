using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminDeviceSourceFoundationClient
    {
        void Init(IFoundationClient root);
        Task<IEnumerable<DeviceSourceViewModel>> GetMany(DeviceSourceFilter filter);
        // Task<DeviceSourceViewModel> Update(Guid id, UpdateDeviceSourceViewModel payload);
        // Task<DeviceSourceViewModel> Create(CreateDeviceSourceViewModel payload);
        // Task Remove(Guid id);
    }
}