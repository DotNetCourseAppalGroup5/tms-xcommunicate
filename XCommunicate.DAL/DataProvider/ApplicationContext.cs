using Models.Entities;
using System.Data.Entity;

namespace EntityFramework.CodeFirst
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("XCommunicate") 
        { }
        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<UserState> UserState { get; set; }
        public DbSet<UserStateHistory> UserStateHistory { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<GroupRole> GroupRoles { get; set; }
        public DbSet<EntityType> EntityType { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Colleague> Colleague { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
