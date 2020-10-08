using Services.Domain.Entities;
using Services.Domain.Interfaces.Repositories;
using Services.Infra.Data.Contexts;


namespace Services.Infra.Data.Repositories
{
    public class RepositoryTransaction : BaseRepository<Transaction>, IRepositoryTransaction
    {
        private ServicesContext _context;


        public RepositoryTransaction(ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}