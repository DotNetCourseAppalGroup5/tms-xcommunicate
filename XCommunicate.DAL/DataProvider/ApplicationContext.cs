using Models.Entities;
using System.Data.Entity;

namespace EntityFramework.CodeFirst
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext() : base("XCommunicate") 
        { }
        public DbSet<Group> Groups { get; set; }
    }
}
