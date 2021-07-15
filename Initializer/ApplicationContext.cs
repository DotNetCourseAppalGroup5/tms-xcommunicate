using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer
{
    public class ApplicationContext : DbContext
    {
        static ApplicationContext()
        {
            Database.SetInitializer(new GropInitializer());
        }

        public ApplicationContext() : base("DbConnection")
        { }

        public DbSet<Group> Groups { get; set; }
        
    }
}
