using DataProvider;
using Models.Entities;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repos
{
    public class LikeRepository : IGenericRepository<Like>
    {
        private ApplicationContext _dbContext;
        private DbSet<Like> likes;
        public LikeRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            likes = _dbContext.Likes;
        }
        public void AddEntity(Like lik)
        {
            likes.Add(lik);
            _dbContext.SaveChanges();
        }

        public void DeleteEntity(int id)
        {
            var likeRemove = likes.Find(id);
            likes.Remove(likeRemove);
            _dbContext.SaveChanges();
        }

        public void DeleteEntityLike(int id, int ent)
        {
            var likeRemove = likes.FirstOrDefault(e => e.EntityId == id && e.UserId == id);
            likes.Remove(likeRemove);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Like> GetAll()
        {
            return likes.ToList();
        }

        public Like GetById(int id)
        {
            return likes.Find(id);
        }

        public void UpdateEntity(Like entity)
        {
            _dbContext.Entry(likes).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}
