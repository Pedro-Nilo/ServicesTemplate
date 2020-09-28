using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;
using R1Services.Infra.Data.Contexts;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryClient : BaseRepository<Client>, IRepositoryClient
    {
        private R1ServicesContext _context;


        public RepositoryClient(R1ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}