using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;


namespace R1Services.Infra.Data
{
    public class TransactionsContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }


        public TransactionsContext(DbContextOptions<TransactionsContext> options) : base(options)
        {
        }
    }
}