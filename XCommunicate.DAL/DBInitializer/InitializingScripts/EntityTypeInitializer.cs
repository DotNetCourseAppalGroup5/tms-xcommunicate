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

            InitializingRepo<EntityType> entityTypeRepo = new InitializingRepo<EntityType>(new ApplicationContext());

            entityTypeRepo.AddEntity(post);
            entityTypeRepo.AddEntity(comment);
        }
    }
}
