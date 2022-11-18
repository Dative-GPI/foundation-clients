using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Shell;

namespace Foundation.Clients.Services
{
    public class ShellFoundationClient : IShellFoundationClient
    {
        private IFoundationClient _root;

        public IShellModelFoundationClient Models { get; }
        public IShellDeviceFoundationClient Devices { get; }
        public IShellOrganisationFoundationClient Organisations { get; }
        public IShellUserOrganisationFoundationClient UserOrganisations { get; }
        public IShellPermissionFoundationClient Permissions { get; }

        public ShellFoundationClient(
            IShellModelFoundationClient models,
            IShellDeviceFoundationClient devices,
            IShellOrganisationFoundationClient organisations,
            IShellUserOrganisationFoundationClient userOrganisations,
            IShellPermissionFoundationClient permissions
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