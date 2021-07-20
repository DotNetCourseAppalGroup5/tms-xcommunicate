using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using Models.Entities;
using Repositories.Repos;
using Services.Services;

namespace WebApp.Controllers
{
    public class EntityController : Controller
    {

        private ApplicationContext _dbContext;
        private EntityRepository _entityRepository = new EntityRepository(new DataProvider.ApplicationContext());
        private LikeRepository _likeRepository = new LikeRepository(new DataProvider.ApplicationContext());

        [HttpGet]
        public ActionResult AddPost()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ResultLike(int id, int UserId)
        {
            //Like myLike = new Like { UserId = 1, EntityId = 1 };
            //_likeRepository.AddEntity(myLike);

            //var userID = User.Identity.GetUserId();

            if (_likeRepository != null)
            {
                var result = _likeRepository.GetAll();
                var likeOperation = result.FirstOrDefault(e => e.UserId == UserId && e.EntityId == id);
                if (likeOperation != null)
                {
                    _likeRepository.DeleteEntityLike(likeOperation.UserId, likeOperation.EntityId);

                }

                else
                {
                    Like like = new Like() { UserId = UserId, EntityId = id };
                    _likeRepository.AddEntity(like);
                }
            }

            return RedirectToAction("ViewAllPosts");
        }

        [HttpPost]
        public ActionResult AddPost(Entity entity)
        {
            entity.EntityTypeId = 1;
            entity.UploadedAt = DateTime.Now;
            entity.EntityParentId = 1;
            entity.ParentGroupId = 1;

            _entityRepository.AddEntity(entity);

            return View();
        }

        [HttpGet]
        public ActionResult ViewAllPosts()
        {
            int parentGroupId = 1;
            var postsToShow = _entityRepository.GetAllForGroup(parentGroupId);

            ViewBag.PostsToShow = postsToShow;

            return View();
        }

        [HttpGet]
        public ActionResult ViewAllPostsTest()
        {
            var postsToShow = _entityRepository.GetAllForGroup(1);

            ViewBag.PostsToShow = postsToShow;

            return View();
        }

        private ActionResult ViewPost(Entity entity)
        {
            EntityService entityService = new EntityService();
            bool isLiked = entityService.EntityHasCurrentUserLike(entity.Id);

            ViewBag.IsLiked = isLiked;
            
            ViewBag.EntityId = entity.Id;
            ViewBag.UserId = entity.UserId;
            ViewBag.UpdatedAt = entity.UpdatedAt;
            ViewBag.Content = entity.Content;

            return PartialView(entity);
        }

        [HttpGet]
        public ActionResult EditPost(int id)
        {
            Entity post = _entityRepository.GetById(id);

            ViewBag.Id = post.Id;
            ViewBag.UserId = post.UserId;
            ViewBag.UploadedAt = post.UploadedAt;
            ViewBag.Content = post.Content;

            return View(post);
        }

        [HttpPost]
        public ActionResult EditPost(Entity post)
        {
            post.UpdatedAt = DateTime.Now;

            _entityRepository.UpdateEntity(post);

            return RedirectToAction("ViewAllPosts");
        }

        [HttpGet]
        public ActionResult DeletePost(int id)
        {
            Entity post = _entityRepository.GetById(id);

            ViewBag.Id = post.Id;

            return View(post);
        }

        [HttpPost]
        public ActionResult DeletePost(Entity post)
        {
            _entityRepository.DeleteEntity(post.Id);

            return RedirectToAction("ViewAllPosts");
        }
    }
}