using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using R1Services.Infra.Data.Contexts;

namespace R1Services.Infra.CrossCutting.IoC
{
    public static class PostgreSqlDependency
    {
        public static void AddPostgreSqlDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<R1ServicesContext>(options =>
            {
                var connectionString = configuration["ConnectionStrings:BooksDBConnectionString"];

                options.UseNpgsql(connectionString);
            });
        }
    }
}
