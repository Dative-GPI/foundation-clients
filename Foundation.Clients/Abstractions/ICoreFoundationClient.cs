using Foundation.Clients.Abstractions.Core;

namespace Foundation.Clients.Abstractions
{
    public interface ICoreFoundationClient
    {
        void Init(IFoundationClient root);
        ICoreModelFoundationClient Models { get; }
        ICoreDeviceFoundationClient Devices { get; }
        ICoreOrganisationFoundationClient Organisations { get; }
        ICoreUserOrganisationFoundationClient UserOrganisations { get; }
        ICorePermissionFoundationClient Permissions { get; }
    }
}