using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Services.Domain.Entities;

namespace Services.Infra.Data.Contexts
{
    public class ServicesContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Transaction> Transactions { get; set; }


        public ServicesContext(DbContextOptions<ServicesContext> options) : base(options)
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