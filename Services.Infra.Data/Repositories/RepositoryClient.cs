using Services.Domain.Entities;
using Services.Domain.Interfaces.Repositories;
using Services.Infra.Data.Contexts;


namespace Services.Infra.Data.Repositories
{
    public class RepositoryClient : BaseRepository<Client>, IRepositoryClient
    {
        private ServicesContext _context;


        public RepositoryClient(ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}