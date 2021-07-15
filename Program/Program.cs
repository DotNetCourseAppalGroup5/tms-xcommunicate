using EntityFramework.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        private static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContext())
            {
              

                var groupCount = context.Groups.Count();
                Console.WriteLine($"Added {groupCount} records to {nameof(context.Groups)} table.");

                
                Console.WriteLine("Done.");
            }

            Console.ReadKey();
        }
    }
}
