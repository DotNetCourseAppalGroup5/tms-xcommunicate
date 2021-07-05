using Models.Entities;

namespace Services.Interfaces
{
    public interface IGroupUserService
    {
        bool Add();
        void Delete(int groupUserId);
        void Update(GroupUser groupUser);
    }
}
