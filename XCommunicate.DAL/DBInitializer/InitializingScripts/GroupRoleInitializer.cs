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

            InitializingGenericRepo<GroupRole> groupRoleRepo = new InitializingGenericRepo<GroupRole>(new ApplicationContext());

            groupRoleRepo.Create(ownerRole, adminRole, userRole);
        }
    }
}
