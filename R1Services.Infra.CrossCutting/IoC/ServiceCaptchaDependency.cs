using Microsoft.Extensions.DependencyInjection;
using R1Services.Service.Services;
using R1Services.Domain.Interfaces.Services;


namespace R1Services.Infra.CrossCutting.IoC
{
    public static class ServiceCaptchaDependency
    {
        public static void AddServiceCaptchaDependency(this IServiceCollection services)
        {
            services.AddScoped<IServiceCaptcha, ServiceCaptcha>();
        }
    }
}