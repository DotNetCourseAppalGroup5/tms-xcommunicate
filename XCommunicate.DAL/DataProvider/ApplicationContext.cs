using Models.Entities;
using System.Data.Entity;

namespace DataProvider
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext() : base("DefaultConnection") // проверить строку подключения
        { }
        public DbSet<Group> Groups { get; set; }
    }
}
