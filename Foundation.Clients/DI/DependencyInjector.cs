using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Foundation.Clients.Abstractions;
using Foundation.Clients.Abstractions.Core;
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
            services.AddTransient<ICoreFoundationClient, CoreFoundationClient>();
            services.AddTransient<IGatewayFoundationClient, GatewayFoundationClient>();
            services.AddTransient<IDispatcherFoundationClient, DispatcherFoundationClient>();

            services.AddTransient<ICoreModelFoundationClient, CoreModelFoundationClient>();
            services.AddTransient<ICoreDeviceFoundationClient, CoreDeviceFoundationClient>();
            services.AddTransient<ICoreOrganisationFoundationClient, CoreOrganisationFoundationClient>();
            services.AddTransient<ICoreUserOrganisationFoundationClient, CoreUserOrganisationFoundationClient>();
            services.AddTransient<ICorePermissionFoundationClient, CorePermissionFoundationClient>();

            services.AddTransient<IGatewayUserFoundationClient, GatewayUserFoundationClient>();
            services.AddTransient<IGatewayAccountFoundationClient, GatewayAccountFoundationClient>();
            services.AddTransient<IGatewayTranslationFoundationClient, GatewayTranslationFoundationClient>();

            services.AddTransient<IAdminDeviceFoundationClient, AdminDeviceFoundationClient>();
            services.AddTransient<IAdminDeviceOrganisationFoundationClient, AdminDeviceOrganisationFoundationClient>();
            services.AddTransient<IAdminDeviceSourceFoundationClient, AdminDeviceSourceFoundationClient>();
            services.AddTransient<IAdminDeviceTwinFoundationClient, AdminDeviceTwinFoundationClient>();
            services.AddTransient<IAdminOrganisationFoundationClient, AdminOrganisationFoundationClient>();
            services.AddTransient<IAdminOrganisationTypeFoundationClient, AdminOrganisationTypeFoundationClient>();
            services.AddTransient<IAdminPermissionFoundationClient, AdminPermissionFoundationClient>();
            services.AddTransient<IAdminRoutineFoundationClient, AdminRoutineFoundationClient>();
            services.AddTransient<IAdminRoutineExecutionFoundationClient, AdminRoutineExecutionFoundationClient>();
            services.AddTransient<IAdminSourceFoundationClient, AdminSourceFoundationClient>();
            services.AddTransient<IAdminUserApplicationFoundationClient, AdminUserApplicationFoundationClient>();

            services.AddTransient<IDispatcherRoutineFoundationClient, DispatcherRoutineFoundationClient>();

            return services;
        }
    }
}