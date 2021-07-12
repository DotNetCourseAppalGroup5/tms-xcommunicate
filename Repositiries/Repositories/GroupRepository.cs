using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositiries.Repositories
{
    public class GroupRepository : IGenericRepository<Group>
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<Group> Groups;

        public GroupRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            Groups = _dbContext.Companies;
        }

        public IEnumerable<Group> GetAll()
        {
            return Groups.ToList();
        }

        public Group GetById(int id)
        {
            return Groups.Find(id);
        }

        public void Add(Group group)
        {
            Groups.Add(group);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var groupToRemove = Groups.Find(id);
            Groups.Remove(groupToRemove);
            _dbContext.SaveChanges();
        }

        public void Edit(Group group)
        {
            Groups.Update(group);
            _dbContext.SaveChanges();
        }
    }
}
