using Foundation.SourceClients.Abstractions;
using Foundation.SourceClients.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Foundation.SourceClients.DI
{
    public static class DependencyInjector
    {
        public static IServiceCollection AddFoundationSourceClients(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IFoundationClient, FoundationClient>();
            services.AddTransient<IFoundationAccountClient, FoundationAccountClient>();

            return services;
        }
    }
}