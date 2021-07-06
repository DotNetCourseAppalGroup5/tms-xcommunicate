using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IInitializingGenericRepository<TEntity> where TEntity : class
    {
        void Create(params TEntity[] entities);
        void Delete(params TEntity[] entities);
    }
}
