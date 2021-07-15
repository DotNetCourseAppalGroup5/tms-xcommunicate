using DataProvider;
using Models.Entities;
using Repositories.IGenericRepository;
using Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializer
{
    public class GropInitializer : DropCreateDatabaseAlways<ApplicationContext>
    {
        protected override void Seed(ApplicationContext context)
        {

            Group first = new Group() { Name = "FISRET", IsPrivate = true, GroupAvatar = "1221" };
            // initializing GroupRoles table



            context.Groups.Add(first);

            context.SaveChanges();
        }
    }
}
