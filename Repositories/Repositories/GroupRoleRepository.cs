using EntityFramework.CodeFirst;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Repositories
{
    public class GroupRoleRepository
    {
        private readonly ApplicationContext _dbContext;
        private readonly DbSet<GroupRole> _roles;

        public GroupRoleRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
            _roles = _dbContext.GroupRoles;
        }
        public void Add(GroupRole role)
        {
            _roles.Add(role);
            _dbContext.SaveChanges();
        }

    }
}
