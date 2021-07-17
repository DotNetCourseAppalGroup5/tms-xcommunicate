using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using Models.Entities;
using Repositories.Repos;


namespace WebApp.Controllers
{
    public class EntityController: Controller
    {

        private ApplicationContext _dbContext;
        private EntityRepository _entityRepository;

        int groupId = 1;

        public ActionResult Index(int parentGroupId)
        {
            parentGroupId = groupId;
            var postsToShow = _entityRepository.GetAllForGroup(parentGroupId);

            ViewBag.postsToShow = postsToShow;

            return View(groupId);
        }

        public ActionResult PostsToShow(int parentGroupId)
        {
            parentGroupId = 1; 
            var postsToShow = _entityRepository.GetAllForGroup(parentGroupId);
            ViewBag.postsToShow = postsToShow;
            return View();
        }

        public ActionResult AddEntity()
        {
            return View(new Entity());
        }

        [HttpPost]
        public string AddEntity(Entity entity)
        {

            entity.EntityTypeId = 1;
            entity.UploadedAt = DateTime.Now;
            entity.EntityParentId = 1;
            entity.ParentGroupId = 1;

            _entityRepository.AddEntity(entity);
            

            return "ok";
        }
    }
}