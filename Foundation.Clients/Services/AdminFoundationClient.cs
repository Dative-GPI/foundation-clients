using System.Collections.Generic;
using System.Threading.Tasks;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Admin;

namespace Foundation.Clients.Services
{
    public class AdminFoundationClient : IAdminFoundationClient
    {
        private IFoundationClient _root;
        public IAdminDeviceTwinFoundationClient DeviceTwin { get; }
        public IAdminDeviceOrganisationFoundationClient DeviceOrganisations { get; }
        public IAdminUserApplicationFoundationClient UserApplications { get; }
        public IAdminPermissionFoundationClient AdminPermissions { get; }
        public IAdminSourceFoundationClient Sources { get; }
        public IAdminRoutineFoundationClient Routines { get; }
        public IAdminRoutineExecutionFoundationClient RoutineExecutions { get; }

        public AdminFoundationClient(
            IAdminDeviceTwinFoundationClient deviceTwin,
            IAdminDeviceOrganisationFoundationClient deviceOrganisation,
            IAdminUserApplicationFoundationClient userApplication,
            IAdminPermissionFoundationClient adminPermissions,
            IAdminSourceFoundationClient sources,
            IAdminRoutineFoundationClient routines,
            IAdminRoutineExecutionFoundationClient routineExecutions
        )
        {
            DeviceTwin = deviceTwin;
            DeviceOrganisations = deviceOrganisation;
            UserApplications = userApplication;
            AdminPermissions = adminPermissions;
            Sources = sources;
            Routines = routines;
            RoutineExecutions = routineExecutions;
        }


        public void Init(IFoundationClient root)
        {
            this._root = root;

            DeviceTwin.Init(root);
            DeviceOrganisations.Init(root);
            UserApplications.Init(root);
            AdminPermissions.Init(root);
            Sources.Init(root);
            Routines.Init(root);
            RoutineExecutions.Init(root);
        }
    }
}