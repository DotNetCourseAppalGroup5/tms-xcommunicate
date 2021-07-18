using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void AddEntity(TEntity entity);
        void DeleteEntity(int id);
        void UpdateEntity(TEntity entity);
    }
}
