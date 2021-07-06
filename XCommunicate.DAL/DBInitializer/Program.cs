using DBInitializer.InitializingScripts;
using System;

namespace DBInitializer
{
    class Program
    {
        private static void Main(string[] args)
        {
            GroupRoleInitializer.Initialize();
            UserStateInitializer.Initialize();
            EntityTypeInitializer.Initialize();

            Console.WriteLine("Done.");
            Console.ReadKey();
        }
    }
}
