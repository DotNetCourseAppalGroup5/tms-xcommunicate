using Models.Entities;
using System;
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

            Group group1 = new Group { Name = "ЗДАРОВА БАНДИТЫ", GroupDescription = "Тупа чилим с Жорой и Витямбой", IsPrivate = false };
            context.Companies.Add(group1);

            context.SaveChanges();

            //
            Entity entity1 = new Entity { EntityTypeId = 1, UploadedAt = DateTime.Now, Content = "Раз два три", EntityParentId = 1, ParentGroupId = 1 };
            Entity entity2 = new Entity { EntityTypeId = 1, UploadedAt = DateTime.Now, Content = "првоаровр овоарповарповла воапрволарповарлп ваопр ловар п", EntityParentId = 1, ParentGroupId = 1 };

            context.Entity.Add(entity1);
            context.Entity.Add(entity2);

            User myuser = new User() { Name = "Vadim", IsActive = true, Password = "31121988Vadimka", EmailAddress = "vadimbezhkov3112@gmail.com" };
            context.Users.Add(myuser);


            // saving changes in DB
            context.SaveChanges();

            
        }
    }
}
