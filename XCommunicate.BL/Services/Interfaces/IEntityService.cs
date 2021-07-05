using Models.Entities;

namespace Services.Interfaces
{
    public interface IEntityService
    {
        bool Post();
        void Delete(int entityId);
        void Update(Entity entity);
    }
}
