using Foundation.Clients.Abstractions.Admin;

namespace Foundation.Clients.Abstractions
{
    public interface IAdminFoundationClient
    {
        void Init(IFoundationClient root);

        IAdminDeviceFoundationClient Devices { get; }
        IAdminDeviceTwinFoundationClient DeviceTwin { get; }
        IAdminDeviceOrganisationFoundationClient DeviceOrganisations { get; }
        IAdminDeviceSourceFoundationClient DeviceSources { get; }
        IAdminOrganisationFoundationClient Organisations { get; }
        IAdminPermissionFoundationClient Permissions { get; }
        IAdminSourceFoundationClient Sources { get; }
        IAdminRoutineFoundationClient Routines { get; }
        IAdminRoutineExecutionFoundationClient RoutineExecutions { get; }
        IAdminUserApplicationFoundationClient UserApplications { get; }
    }
}