using Foundation.Clients.Abstractions.Admin;

namespace Foundation.Clients.Abstractions
{
    public interface IAdminFoundationClient
    {
        void Init(IFoundationClient root);

        IAdminDeviceTwinFoundationClient DeviceTwin { get; }
        IAdminDeviceOrganisationFoundationClient DeviceOrganisations { get; }
        IAdminUserApplicationFoundationClient UserApplications { get; }
        IAdminPermissionFoundationClient Permissions { get; }
        IAdminSourceFoundationClient Sources { get; }
        IAdminRoutineFoundationClient Routines { get; }
        IAdminRoutineExecutionFoundationClient RoutineExecutions { get; }
    }
}