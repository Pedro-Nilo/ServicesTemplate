using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;


namespace R1Services.Infra.Data
{
    public class ContractsContext : DbContext
    {
        public DbSet<Contract> Contracts { get; set; }


        public ContractsContext(DbContextOptions<ContractsContext> options) : base(options)
        {
        }
    }
}