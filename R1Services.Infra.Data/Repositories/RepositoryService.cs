using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryService : IRepositoryService, IDisposable
    {
        private ServicesContext _context;


        public RepositoryService(ServicesContext context)
        {
            _context = context ??
                throw new ArgumentNullException(nameof(context));
        }


        public void Add(Service serviceToAdd)
        {
            if (serviceToAdd == null)
            {
                throw new ArgumentNullException(nameof(serviceToAdd));
            }

            _context.Add(serviceToAdd);
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            return await _context.Services
                .ToListAsync();
        }

        public async Task<Service> GetByGuidAsync(Guid id)
        {
            return await _context.Services
                .FirstOrDefaultAsync(service => service.Id == id);
        }

        public void Update(Service serviceToUpdate)
        {
            Service service = _context.Services
                .FirstOrDefault(client => client.Id == serviceToUpdate.Id);

            service = serviceToUpdate;
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