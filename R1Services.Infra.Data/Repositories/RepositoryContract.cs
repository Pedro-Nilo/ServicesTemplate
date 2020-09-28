using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryContract : IRepositoryContract, IDisposable
    {
        private ContractsContext _context;


        public RepositoryContract(ContractsContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        public void Add(Contract contractToAdd)
        {
            if (contractToAdd == null)
            {
                throw new ArgumentNullException(nameof(contractToAdd));
            }

            _context.Add(contractToAdd);
        }

        public async Task<IEnumerable<Contract>> GetAllAsync()
        {
            return await _context.Contracts
                .ToListAsync();
        }

        public async Task<Contract> GetByGuidAsync(Guid id)
        {
            return await _context.Contracts
                .FirstOrDefaultAsync(contract => contract.Id == id);
        }

        public void Update(Contract contractToUpdate)
        {
            var contract = _context.Contracts
                .FirstOrDefault(client => client.Id == contractToUpdate.Id);

            contract = contractToUpdate;
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