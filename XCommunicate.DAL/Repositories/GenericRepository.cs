using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _dbContext;
        DbSet<TEntity> _dbSet;

        public GenericRepository(DbContext context)
        {
            _dbContext = context;
            _dbSet = context.Set<TEntity>();
        }

        public void AddEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateEntity(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
