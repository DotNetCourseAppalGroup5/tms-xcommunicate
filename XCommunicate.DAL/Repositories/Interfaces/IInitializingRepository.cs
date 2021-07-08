namespace Repositories.Interfaces
{
    public interface IInitializingRepository<TEntity> where TEntity : class
    {
        void Create(params TEntity[] entities);
        void Delete(params TEntity[] entities);
    }
}
