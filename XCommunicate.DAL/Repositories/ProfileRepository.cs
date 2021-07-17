using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models.Entities;
using DataProvider;

namespace Repositories
{
    public class ProfileRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly DbSet<UserProfile> Profiles;

        public ProfileRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Profiles = _dbContext.Profiles;
        }

        public IEnumerable<UserProfile> GetAll()
        {
            return Profiles.ToList();
        }

        public UserProfile GetById(string id)
        {
            return Profiles.Find(id);
        }

        public void Add(UserProfile profile)
        {
            Profiles.Add(profile);
            _dbContext.SaveChanges();
        }

        public void Delete(string id)
        {
            var profile = Profiles.Find(id);
            Profiles.Remove(profile);
            _dbContext.SaveChanges();
        }

        public void Edit(UserProfile profile)
        {
            _dbContext.Entry(profile).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}