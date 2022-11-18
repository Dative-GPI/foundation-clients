using System.Collections.Generic;
using System.Threading.Tasks;
using Foundation.Clients.ViewModels.Admin;

namespace Foundation.Clients.Abstractions.Admin
{
    public interface IAdminPermissionFoundationClient
    {
        void Init(IFoundationClient root);
        Task<IEnumerable<PermissionAdminInfosViewModel>> GetMany();
    }
}