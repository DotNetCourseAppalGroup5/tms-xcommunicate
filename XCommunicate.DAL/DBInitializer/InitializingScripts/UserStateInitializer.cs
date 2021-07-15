//using DataProvider;
//using Models.Entities;
//using Repositories.Repos;

//namespace DBInitializer.InitializingScripts
//{
//    class UserStateInitializer
//    {
//        internal static void Initialize()
//        {
//            UserState activeState = new UserState() { Name = "Active" };
//            UserState deactivatedState = new UserState() { Name = "Deactivated" };

//            InitializingRepo<UserState> userStateRepo = new InitializingRepo<UserState>(new ApplicationContext());

//            userStateRepo.Create(activeState, deactivatedState);
//        }
//    }
//}
