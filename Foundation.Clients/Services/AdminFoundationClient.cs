using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Admin;

namespace Foundation.Clients.Services
{
    public class AdminFoundationClient : IAdminFoundationClient
    {
        private IFoundationClient _root;

        public IAdminDeviceFoundationClient Devices { get; }
        public IAdminDeviceTwinFoundationClient DeviceTwin { get; }
        public IAdminDeviceOrganisationFoundationClient DeviceOrganisations { get; }
        public IAdminDeviceSourceFoundationClient DeviceSources { get; }
        public IAdminUserApplicationFoundationClient UserApplications { get; }
        public IAdminPermissionFoundationClient Permissions { get; }
        public IAdminSourceFoundationClient Sources { get; }
        public IAdminRoutineFoundationClient Routines { get; }
        public IAdminRoutineExecutionFoundationClient RoutineExecutions { get; }

        public AdminFoundationClient(
            IAdminDeviceFoundationClient device,
            IAdminDeviceOrganisationFoundationClient deviceOrganisation,
            IAdminDeviceSourceFoundationClient deviceSource,
            IAdminDeviceTwinFoundationClient deviceTwin,
            IAdminPermissionFoundationClient permission,
            IAdminRoutineFoundationClient routines,
            IAdminRoutineExecutionFoundationClient routineExecutions,
            IAdminSourceFoundationClient sources,
            IAdminUserApplicationFoundationClient userApplication
        )
        {
            Devices = device;
            DeviceOrganisations = deviceOrganisation;
            DeviceSources = deviceSource;
            DeviceTwin = deviceTwin;
            Permissions = permission;
            Routines = routines;
            RoutineExecutions = routineExecutions;
            Sources = sources;
            UserApplications = userApplication;
        }


        public void Init(IFoundationClient root)
        {
            this._root = root;

            Devices.Init(root);
            DeviceOrganisations.Init(root);
            DeviceSources.Init(root);
            DeviceTwin.Init(root);
            Permissions.Init(root);
            Routines.Init(root);
            RoutineExecutions.Init(root);
            Sources.Init(root);
            UserApplications.Init(root);
        }
    }
}