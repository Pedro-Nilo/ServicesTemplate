using Services.Domain.Entities;
using Services.Domain.Interfaces.Repositories;
using Services.Infra.Data.Contexts;


namespace Services.Infra.Data.Repositories
{
    public class RepositoryService : BaseRepository<Service>, IRepositoryService
    {
        private ServicesContext _context;


        public RepositoryService(ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}