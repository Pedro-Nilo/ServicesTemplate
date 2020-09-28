using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;


namespace R1Services.Infra.Data
{
    public class ServicesContext : DbContext
    {
        public DbSet<Service> Services { get; set; }


        public ServicesContext(DbContextOptions<ServicesContext> options) : base(options)
        {
        }
    }
}