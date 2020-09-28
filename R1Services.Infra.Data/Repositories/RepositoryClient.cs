using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryClient : IRepositoryClient, IDisposable
    {
        private ClientsContext _context;


        public RepositoryClient(ClientsContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        public void Add(Client clientToAdd)
        {
            if (clientToAdd == null)
            {
                throw new ArgumentNullException(nameof(clientToAdd));
            }

            _context.Add(clientToAdd);
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _context.Clients
                .ToListAsync();
        }

        public async Task<Client> GetByGuidAsync(Guid id)
        {
            return await _context.Clients
                .FirstOrDefaultAsync(client => client.Id == id);
        }

        public void Update(Client clientToUpdate)
        {
            var client = _context.Clients
                .FirstOrDefault(client => client.Id == clientToUpdate.Id);

            client = clientToUpdate;
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