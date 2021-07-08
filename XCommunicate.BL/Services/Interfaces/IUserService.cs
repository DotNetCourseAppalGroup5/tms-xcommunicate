using Models.Entities;

namespace Services.Interfaces
{
    public interface IUserService
    {
        bool Create();
        void Delete(int userId);
        void Update(User user);
    }
}
