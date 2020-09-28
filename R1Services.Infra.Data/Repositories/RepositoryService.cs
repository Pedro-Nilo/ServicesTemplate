using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;
using R1Services.Infra.Data.Contexts;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryService : BaseRepository<Service>, IRepositoryService
    {
        private R1ServicesContext _context;


        public RepositoryService(R1ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}