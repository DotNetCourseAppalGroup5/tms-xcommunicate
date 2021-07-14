using Models.Entities;
using System.Data.Entity;

namespace DataProvider
{
    public class ApplicationContext : DbContext
    {
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<GroupRole> GroupRoles { get; set; }
        public DbSet<UserState> UserStates { get; set; }
    }
}
