using Microsoft.Extensions.DependencyInjection;
using Services.Domain.Interfaces.Repositories;
using Services.Infra.Data.Repositories;


namespace Services.Infra.CrossCutting.IoC
{
    public static class RepositoryTransactionDependency
    {
        public static void AddRepositoryTransactionDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryTransaction, RepositoryTransaction>();
        }
    }
}