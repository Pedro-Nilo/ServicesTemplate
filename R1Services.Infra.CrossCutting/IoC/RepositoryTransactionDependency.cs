using Microsoft.Extensions.DependencyInjection;
using R1Services.Domain.Interfaces.Repositories;
using R1Services.Infra.Data.Repositories;


namespace R1Services.Infra.CrossCutting.IoC
{
    public static class RepositoryTransactionDependency
    {
        public static void AddRepositoryTransactionDependency(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryTransaction, RepositoryTransaction>();
        }
    }
}