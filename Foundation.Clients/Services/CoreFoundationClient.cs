using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Core;

namespace Foundation.Clients.Services
{
    public class CoreFoundationClient : ICoreFoundationClient
    {
        private IFoundationClient _root;

        public ICoreModelFoundationClient Models { get; }
        public ICoreDeviceFoundationClient Devices { get; }
        public ICoreOrganisationFoundationClient Organisations { get; }
        public ICoreUserOrganisationFoundationClient UserOrganisations { get; }
        public ICorePermissionFoundationClient Permissions { get; }

        public CoreFoundationClient(
            ICoreModelFoundationClient models,
            ICoreDeviceFoundationClient devices,
            ICoreOrganisationFoundationClient organisations,
            ICoreUserOrganisationFoundationClient userOrganisations,
            ICorePermissionFoundationClient permissions
        )
        {
            Models = models;
            Devices = devices;
            Organisations = organisations;
            UserOrganisations = userOrganisations;
            Permissions = permissions;
        }

        public void Init(IFoundationClient root)
        {
            this._root = root;

            Models.Init(root);
            Devices.Init(root);
            Organisations.Init(root);
            UserOrganisations.Init(root);
            Permissions.Init(root);
        }
    }
}