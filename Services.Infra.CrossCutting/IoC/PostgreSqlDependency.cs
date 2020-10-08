using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.Infra.Data.Contexts;

namespace Services.Infra.CrossCutting.IoC
{
    public static class PostgreSqlDependency
    {
        public static void AddPostgreSqlDependency(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ServicesContext>(options =>
            {
                var connectionString = configuration["ConnectionStrings:BooksDBConnectionString"];

                options.UseNpgsql(connectionString);
            });
        }
    }
}
