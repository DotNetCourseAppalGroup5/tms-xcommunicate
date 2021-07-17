using System.Collections.Generic;
using System.Linq;
using Models.Entities;
using Repositories.Interfaces;
using DataProvider;
using System.Data.Entity;

namespace Repositories.Repos
{
    public class EntityRepository : IGenericRepository<Entity>
    {
        private ApplicationContext _dbContext;
        private DbSet<Entity> entities;

        public EntityRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            entities = _dbContext.Entity;
        }

        public void AddEntity(Entity entity)
        {
            entities.Add(entity);
            _dbContext.SaveChanges();
        }

        public List<Entity> GetAllForGroup(int parentGroupId)
        {
            IQueryable<Entity> postsForGroup = entities;

            var postsToShow = entities.Where(e => e.ParentGroupId == parentGroupId && e.EntityTypeId == 1).ToList();

            return postsToShow;
        }

        public Entity GetById(int id)
        {
            return entities.Find(id);
        }

        public IEnumerable<Entity> GetAll()
        {
            return entities.ToList();
        }

        public void UpdateEntity(Entity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            var groupToRemove = entities.Find(id);
            entities.Remove(groupToRemove);
            _dbContext.SaveChanges();
        }
    }
}
