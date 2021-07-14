using DataProvider;
using Models.Entities;
using Repositories.Repos;

namespace DBInitializer.InitializingScripts
{
    class GroupRoleInitializer
    {
        internal static void Initialize()
        {
            GroupRole ownerRole = new GroupRole() { Name = "Owner" };
            GroupRole adminRole = new GroupRole() { Name = "Admin" };
            GroupRole userRole = new GroupRole() { Name = "User" };

            InitializingRepo<GroupRole> groupRoleRepo = new InitializingRepo<GroupRole>(new ApplicationContext());

            groupRoleRepo.AddEntity(ownerRole);
            groupRoleRepo.AddEntity(adminRole);
            groupRoleRepo.AddEntity(userRole);
        }
    }
}
