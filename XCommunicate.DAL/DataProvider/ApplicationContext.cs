using Models.Entities;
using System.Data.Entity;

namespace EntityFramework.CodeFirst
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("XCommunicate") 
        { }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupRole> GroupRoles { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<User> Users { get; set; }

        public System.Data.Entity.DbSet<Models.Entities.UserProfile> UserProfiles { get; set; }
    }
}
