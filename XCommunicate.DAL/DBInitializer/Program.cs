using DataProvider;
using System;
using System.Linq;

namespace DBInitializer
{
    class Program
    {
        private static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
                var entityTypesCount = context.EntityTypes.Count();
                Console.WriteLine($"Added {entityTypesCount} records to {nameof(context.EntityTypes)} table.");

                var groupRolesCount = context.GroupRoles.Count();
                Console.WriteLine($"Added {groupRolesCount} records to {nameof(context.GroupRoles)} table.");

                var userStatesCount = context.UserStates.Count();
                Console.WriteLine($"Added {userStatesCount} records to {nameof(context.UserStates)} table.");

                Console.WriteLine("Done.");
            }
        }
    }
}
