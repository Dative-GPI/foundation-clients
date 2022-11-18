using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminDeviceOrganisationFoundationClient
    {
        void Init(IFoundationClient root);
        Task<IEnumerable<DeviceOrganisationInfosViewModel>> GetMany(DeviceOrganisationsFilter filter);
    }
}