using Models.Entities;
using System.Data.Entity;

namespace DataProvider
{
    public class ApplicationContext : DbContext
    {
        static ApplicationContext()
        {
            Database.SetInitializer(new ApplicationContextInitializer());
        }

        public ApplicationContext() : base("DbConnection") 
        { }

        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<GroupRole> GroupRoles { get; set; }
        public DbSet<UserState> UserStates { get; set; }
        public DbSet<Group> Companies { get; set; }
    }
}
