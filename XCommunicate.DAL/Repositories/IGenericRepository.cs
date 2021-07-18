using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Add(TEntity entity);
        void Delete(int id);
        void Edit(TEntity entity);
    }
}
