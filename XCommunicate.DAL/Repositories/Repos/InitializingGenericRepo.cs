using Repositories.Interfaces;
using System.Data.Entity;

namespace Repositories.Repos
{
    public class InitializingGenericRepo<TEntity> : IInitializingGenericRepository<TEntity> where TEntity : class
    {
        DbContext _dbContext;
        DbSet<TEntity> _dbSet;

        public InitializingGenericRepo(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public void Create(params TEntity[] entities)
        {
            foreach (var item in entities)
                _dbSet.Add(item);

            _dbContext.SaveChanges();
        }

        public void Delete(params TEntity[] entities)
        {
            foreach (var item in entities)
                _dbSet.Remove(item);

            _dbContext.SaveChanges();
        }
    }
}
