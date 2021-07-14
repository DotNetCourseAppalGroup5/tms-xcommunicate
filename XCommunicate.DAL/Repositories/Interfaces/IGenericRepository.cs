using System;
using System.Collections.Generic;

namespace Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void AddEntity(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void UpdateEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
    }
}
