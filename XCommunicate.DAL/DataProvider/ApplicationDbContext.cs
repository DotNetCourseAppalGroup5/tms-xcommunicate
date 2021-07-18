using Microsoft.AspNet.Identity.EntityFramework;
using Models.Entities;
using System.Data.Entity;

namespace DataProvider
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public DbSet<UserProfile> Profiles { get; set; }
        public DbSet<UserState> UserState { get; set; }
        public DbSet<UserStateHistory> UserStateHistory { get; set; }
        public DbSet<Message> Message { get; set; }
        public DbSet<Like> Like { get; set; }
        public DbSet<GroupUser> GroupUser { get; set; }
        public DbSet<GroupRole> GroupRole { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<EntityType> EntityType { get; set; }
        public DbSet<Entity> Entity { get; set; }
        public DbSet<Colleague> Colleague { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>().ToTable("Users");
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<UserProfile>().ToTable("Profiles");
            modelBuilder.Entity<UserState>().ToTable("UserStates");
            modelBuilder.Entity<UserStateHistory>().ToTable("UserStateHistories");
            modelBuilder.Entity<Message>().ToTable("Messages");
            modelBuilder.Entity<Like>().ToTable("Like");
            modelBuilder.Entity<GroupUser>().ToTable("GroupUsers");
            modelBuilder.Entity<GroupRole>().ToTable("GroupRoles");
            modelBuilder.Entity<Group>().ToTable("Groups");
            modelBuilder.Entity<EntityType>().ToTable("EntityTypes");
            modelBuilder.Entity<Entity>().ToTable("Entities");
            modelBuilder.Entity<Colleague>().ToTable("Colleagues");
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
