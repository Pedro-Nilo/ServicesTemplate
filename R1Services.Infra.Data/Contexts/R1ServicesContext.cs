using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;

namespace R1Services.Infra.Data.Contexts
{
    public class R1ServicesContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Transaction> Transactions { get; set; }


        public R1ServicesContext(DbContextOptions<R1ServicesContext> options) : base(options)
        {
        }


        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("TransactionDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("TransactionDate").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("TransactionDate").IsModified = false;
                }
            }

            return base.SaveChanges();
        }
    }
}