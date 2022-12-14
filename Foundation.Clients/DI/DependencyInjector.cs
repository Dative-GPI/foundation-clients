using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Shell;
using Foundation.Clients.Abstractions.Gateway;

using Foundation.Clients.Services;
using Foundation.Clients.Abstractions.Admin;
using Foundation.Clients.Abstractions.Dispatcher;

namespace Foundation.Clients.DI
{
    public static class DependencyInjector
    {
        public static IServiceCollection AddFoundationClients(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IFoundationClient, FoundationClient>();

            services.AddTransient<IAdminFoundationClient, AdminFoundationClient>();
            services.AddTransient<IShellFoundationClient, ShellFoundationClient>();
            services.AddTransient<IGatewayFoundationClient, GatewayFoundationClient>();
            services.AddTransient<IDispatcherFoundationClient, DispatcherFoundationClient>();

            services.AddTransient<IShellModelFoundationClient, ShellModelFoundationClient>();
            services.AddTransient<IShellDeviceFoundationClient, ShellDeviceFoundationClient>();
            services.AddTransient<IShellOrganisationFoundationClient, ShellOrganisationFoundationClient>();
            services.AddTransient<IShellUserOrganisationFoundationClient, ShellUserOrganisationFoundationClient>();
            services.AddTransient<IShellPermissionFoundationClient, ShellPermissionFoundationClient>();

            services.AddTransient<IGatewayUserFoundationClient, GatewayUserFoundationClient>();
            services.AddTransient<IGatewayAccountFoundationClient, GatewayAccountFoundationClient>();
            services.AddTransient<IGatewayTranslationFoundationClient, GatewayTranslationFoundationClient>();

            services.AddTransient<IAdminDeviceTwinFoundationClient, AdminDeviceTwinFoundationClient>();
            services.AddTransient<IAdminDeviceOrganisationFoundationClient, AdminDeviceOrganisationFoundationClient>();
            services.AddTransient<IAdminUserApplicationFoundationClient, AdminUserApplicationFoundationClient>();
            services.AddTransient<IAdminPermissionFoundationClient, AdminPermissionFoundationClient>();
            services.AddTransient<IAdminSourceFoundationClient, AdminSourceFoundationClient>();
            services.AddTransient<IAdminRoutineFoundationClient, AdminRoutineFoundationClient>();
            services.AddTransient<IAdminRoutineExecutionFoundationClient, AdminRoutineExecutionFoundationClient>();

            services.AddTransient<IDispatcherRoutineFoundationClient, DispatcherRoutineFoundationClient>();

            return services;
        }
    }
}