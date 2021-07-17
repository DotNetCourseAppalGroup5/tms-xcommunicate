namespace WebApp.Controllers
{
    internal interface IGenericRepository<T>
    {
        object GetAllForGroup(int parentGroupId);
    }
}