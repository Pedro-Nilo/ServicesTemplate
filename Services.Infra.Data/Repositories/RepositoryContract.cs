using Services.Domain.Entities;
using Services.Domain.Interfaces.Repositories;
using Services.Infra.Data.Contexts;


namespace Services.Infra.Data.Repositories
{
    public class RepositoryContract : BaseRepository<Contract>, IRepositoryContract
    {
        private ServicesContext _context;


        public RepositoryContract(ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}