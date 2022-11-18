using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminDeviceTwinFoundationClient
    {
        void Init(IFoundationClient root);
        Task<DeviceTwinViewModel> Get(Guid deviceId);
        Task<IEnumerable<DeviceTwinViewModel>> GetMany(List<Guid> deviceIds);
        Task Update(Guid deviceId, UpdateDeviceTwinViewModel payload);
    }
}