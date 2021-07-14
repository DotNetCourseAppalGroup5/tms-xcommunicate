using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Repositories.Repos
{
    public class InitializingRepo<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        DbContext _dbContext;
        DbSet<TEntity> _dbSet;

        public InitializingRepo(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public void AddEntity(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteEntity(TEntity entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
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
