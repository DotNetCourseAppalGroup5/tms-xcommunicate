using DataProvider;
using Models.Entities;
using Repositories.IGenericRepository;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Repositories.Repositories
{
    public class GroupRepository : IGenericRepository<Group>
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<Group> groups;

        public GroupRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            groups = _dbContext.Groups;
        }

        public IEnumerable<Group> GetAll()
        {
            return groups.ToList();
        }

        public Group GetById(int id)
        {
            return groups.Find(id);
        }

        public void Add(Group group)
        {
            groups.Add(group);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var groupToRemove = groups.Find(id);
            groups.Remove(groupToRemove);
            _dbContext.SaveChanges();
        }

        public void Edit(Group group) 
        {
            _dbContext.Entry(group).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
