
using EntityFramework.CodeFirst;

using Models.Entities;
using Repositories.IGenericRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        private readonly IGenericRepository<Group> _groupRepository;
        private readonly ApplicationContext _dbContext;

        public GroupController(IGenericRepository<Group> groupRepository, ApplicationContext dbContext)
        {
            _groupRepository = groupRepository;
            _dbContext = dbContext;
        }

        public ActionResult Index()
        {
            var companies = _groupRepository.GetAll();
            return View(companies);
        }

        public ViewResult Details(int id)
        {
            Group group = _groupRepository.GetById(id);
            return View(group);
        }

        public ActionResult Create()
        {
            return View(new Group());
        }

        [HttpPost]
        public ActionResult Create(Group group)
        {
            if (ModelState.IsValid )
            {
                ViewBag.Message = "Exist";
                return View(group);
            }

            else
            {
                _groupRepository.Add(group);
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            Group group = _groupRepository.GetById(id);
            return View(group);
        }

        [HttpPost]
        public ActionResult Edit(Group group)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _groupRepository.Edit(group);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again.");
            }

            return View(group);
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            if (saveChangesError.GetValueOrDefault())
            {
                ViewBag.ErrorMessage = "Unable to save changes. Try again, and if the problem persists see your system administrator.";
            }

            Group company = _groupRepository.GetById(id);
            return View(company);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteGroup(int id)
        {
            _groupRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}