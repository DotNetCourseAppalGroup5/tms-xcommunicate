using Models.Entities;

namespace Services.Interfaces
{
    public interface IGroupService
    {
        bool Create();
        void Delete(int groupId);
        void Update(Group group);
    }
}
