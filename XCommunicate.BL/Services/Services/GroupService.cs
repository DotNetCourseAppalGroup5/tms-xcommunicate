
using DataProvider;
using Models.Entities;
using System.Linq;

namespace Services.Services
{
    public class GroupService
    {
        private readonly ApplicationContext _dbContext;

        public bool IsUnique(Group group)
        {
            return _dbContext.Groups.Any(c => c.Name == group.Name);
        }
    }
}
