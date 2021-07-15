using DataProvider;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repositories.Repos
{
    public class InitializingRepo<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<TEntity> entities;
        public InitializingRepo(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddEntity(TEntity entity)
        {
            entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            TEntity entity = entities.Find(id);
            entities.Remove(entity);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return entities.ToList();
        }

        public TEntity GetById(int id)
        {
            return entities.Find(id);
        }

        public void UpdateEntity(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
