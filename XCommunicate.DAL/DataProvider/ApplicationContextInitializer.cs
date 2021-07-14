using Models.Entities;
using System.Data.Entity;

namespace DataProvider
{
    class ApplicationContextInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {
            // initializing EntityTypes table
            EntityType post = new EntityType() { Name = "Post" };
            EntityType comment = new EntityType() { Name = "Comment" };

            context.EntityTypes.Add(post);
            context.EntityTypes.Add(comment);

            // initializing GroupRoles table
            GroupRole ownerRole = new GroupRole() { Name = "Owner" };
            GroupRole adminRole = new GroupRole() { Name = "Admin" };
            GroupRole userRole = new GroupRole() { Name = "User" };

            context.GroupRoles.Add(ownerRole);
            context.GroupRoles.Add(adminRole);
            context.GroupRoles.Add(userRole);

            // initializing UserStates table
            UserState activeState = new UserState() { Name = "Active" };
            UserState deactivatedState = new UserState() { Name = "Deactivated" };

            context.UserStates.Add(activeState);
            context.UserStates.Add(deactivatedState);

            // saving changes in DB
            context.SaveChanges();
        }
    }
}
