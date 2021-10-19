using BusinessLayer.CustomerUseCases;
using BusinessLayer.Gateways;
using BusinessLayer.Interfaces;
using DAL.Gateways;
using Microsoft.Extensions.DependencyInjection;

namespace API.ServicesConfig
{
    public static class ServiceProviderExtensions
    {
        public static void AddUseCaseServices(this IServiceCollection services)
        {
            services.AddTransient<IWatchCatalogUseCase, WatchCatalogUseCase>();
        }

        public static void AddGatewayServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryGateway, CategoryGateway>();
        }
    }
}
