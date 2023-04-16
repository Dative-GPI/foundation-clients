using System;
using System.Threading.Tasks;
using Foundation.Clients.Abstractions.Admin;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Services
{
    public class AdminDeviceFoundationClient : IAdminDeviceFoundationClient
    {
        
        public Task<DeviceDetailsViewModel> UpdateOwner(Guid deviceId, Guid ownerId)
        {
            throw new NotImplementedException();
        }
    }
}