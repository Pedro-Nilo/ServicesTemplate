using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;


namespace R1Services.Infra.Data
{
    public class ClientsContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }


        public ClientsContext(DbContextOptions<ClientsContext> options) : base(options)
        {
        }
    }
}