using R1Services.Domain.Entities;
using R1Services.Domain.Interfaces.Repositories;
using R1Services.Infra.Data.Contexts;


namespace R1Services.Infra.Data.Repositories
{
    public class RepositoryTransaction : BaseRepository<Transaction>, IRepositoryTransaction
    {
        private R1ServicesContext _context;


        public RepositoryTransaction(R1ServicesContext context) : base(context)
        {
            _context = context;
        }
    }
}