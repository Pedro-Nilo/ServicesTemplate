using Microsoft.Extensions.DependencyInjection;
using Services.Service.Services;
using Services.Domain.Interfaces.Services;


namespace Services.Infra.CrossCutting.IoC
{
    public static class ServiceCaptchaDependency
    {
        public static void AddServiceCaptchaDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceCaptcha, ServiceCaptcha>();
        }
    }
}