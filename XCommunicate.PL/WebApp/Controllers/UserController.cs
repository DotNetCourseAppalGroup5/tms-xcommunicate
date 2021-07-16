using EntityFramework.CodeFirst;
using Models.Entities;
using Repositories.IGenericRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IGenericRepository<User> _userRepository;
        private readonly ApplicationContext _dbContext;
        // GET: User
        public UserController(IGenericRepository<User> userRepository, ApplicationContext dbContext)
        {
            _userRepository = userRepository;
            _dbContext = dbContext;
        }
        public ActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_dbContext.Groups, "Id", "Name");

            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(GroupUser groupUser, User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _userRepository.Add(user);
                    CountUserAdd(groupUser);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again.");
            }

            return View(user);


        }
        public void CountUserAdd(GroupUser groupUser)
        {
            var id = groupUser.UserId;
            var group = _dbContext.Groups.Find(id);
            group.Size++;
            _dbContext.Entry(group).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}