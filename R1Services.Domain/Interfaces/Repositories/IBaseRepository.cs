using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace R1Services.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        Task<TEntity> GetByGuidAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        void Update(TEntity obj);

        Task<bool> SaveChangesAsync();
     }
}