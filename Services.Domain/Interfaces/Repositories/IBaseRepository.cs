using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Services.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        Task<TEntity> GetByGuidAsync(Guid id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        void Update(TEntity obj);

        void Dispose();
     }
}