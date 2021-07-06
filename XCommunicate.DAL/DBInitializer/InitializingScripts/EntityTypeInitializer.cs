using DataProvider;
using Models.Entities;
using Repositories.Repos;

namespace DBInitializer.InitializingScripts
{
    class EntityTypeInitializer
    {
        internal static void Initialize()
        {
            EntityType post = new EntityType() { Name = "Post" };
            EntityType comment = new EntityType() { Name = "Comment" };

            InitializingGenericRepo<EntityType> entityTypeRepo = new InitializingGenericRepo<EntityType>(new ApplicationContext());

            entityTypeRepo.Create(post, comment);
        }
    }
}
