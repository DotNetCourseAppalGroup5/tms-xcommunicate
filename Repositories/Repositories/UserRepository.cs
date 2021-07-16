using EntityFramework.CodeFirst;
using Models.Entities;
using Repositories.IGenericRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class UserRepository: IGenericRepository<User>
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<User> users;

        public UserRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            users = _dbContext.Users;
        }

        public IEnumerable<User> GetAll()
        {
            return users.ToList();
        }

        public User GetById(int id)
        {
            return users.Find(id);
        }

        public void Add(User user)
        {
            users.Add(user);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var groupToRemove = users.Find(id);
            users.Remove(groupToRemove);
            _dbContext.SaveChanges();
        }

        public void Edit(User user)
        {
            _dbContext.Entry(user).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
