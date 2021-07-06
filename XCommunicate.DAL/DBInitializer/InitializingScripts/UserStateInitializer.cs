using DataProvider;
using Models.Entities;
using Repositories.Repos;

namespace DBInitializer.InitializingScripts
{
    class UserStateInitializer
    {
        internal static void Initialize()
        {
            UserState activeState = new UserState() { Name = "Active" };
            UserState deactivatedState = new UserState() { Name = "Deactivated" };

            InitializingGenericRepo<UserState> userStateRepo = new InitializingGenericRepo<UserState>(new ApplicationContext());

            userStateRepo.Create(activeState, deactivatedState);
        }
    }
}
