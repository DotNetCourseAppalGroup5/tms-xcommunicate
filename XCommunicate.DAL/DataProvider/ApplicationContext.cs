using Models.Entities;
using System.Data.Entity;

namespace DataProvider
{
    public class ApplicationContext : DbContext
    {
        public DbSet<GroupRole> GroupRoles { get; set; }
    }
}
