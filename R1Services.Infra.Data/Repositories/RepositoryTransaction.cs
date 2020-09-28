using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryTransaction : IRepositoryTransaction, IDisposable
    {
        private TransactionsContext _context;


        public RepositoryTransaction(TransactionsContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        public void Add(Transaction transactionToAdd)
        {
            if (transactionToAdd == null)
            {
                throw new ArgumentNullException(nameof(transactionToAdd));
            }

            _context.Add(transactionToAdd);
        }

        public async Task<IEnumerable<Transaction>> GetAllAsync()
        {
            return await _context.Transactions
                .ToListAsync();
        }

        public async Task<Transaction> GetByGuidAsync(Guid id)
        {
            return await _context.Transactions
                .FirstOrDefaultAsync(transaction => transaction.Id == id);
        }

        public void Update(Transaction transactionToUpdate)
        {
            var transaction = _context.Transactions
                .FirstOrDefault(client => client.Id == transactionToUpdate.Id);

            transaction = transactionToUpdate;
        }


        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync() > 0);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                if(_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}