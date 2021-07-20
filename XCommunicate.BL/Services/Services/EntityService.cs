using DataProvider;
using Models.Entities;
using Repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class EntityService
    {
        private EntityRepository _entityRepo;
        private LikeRepository _likeRepo;

        public bool EntityHasCurrentUserLike(int id)
        {
            bool isLiked;

            using (ApplicationContext _dbContext = new ApplicationContext())
            {
                _entityRepo = new EntityRepository(_dbContext);
                _likeRepo = new LikeRepository(_dbContext);

                // это нужно потом поменять на айди текущего юзера, а пока что тут заглушка в виде UserId = 1
                var userId = 1;
                var entityId = _entityRepo.GetById(id).Id;

                var like = _likeRepo.GetAll().FirstOrDefault(l => l.UserId == userId && l.EntityId == entityId);

                if (like == null)
                    isLiked = false;
                else
                    isLiked = true;
            }

            return isLiked;
        }
    }
}
