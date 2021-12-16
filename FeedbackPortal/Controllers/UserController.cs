using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeedbackPortal.Models;

namespace FeedbackPortal.Controllers
{
    public class UserController : Controller
    {

        public static List<User> users =new List<User>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Get")]
        public IActionResult Get()
        {
            
            return View(users);
        }

        [HttpGet]
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("Create")]
        public IActionResult Create(User user)//add user
        {
            users.Add(user);
            return RedirectToAction("Get", users);
        }

        [HttpGet]
        [Route("Edit")]
        public IActionResult Edit(int id)//display user
        {
            User User = users.Where(use => use.Id.Equals(id)).Select(use => use).FirstOrDefault();
            return View();
        }  

        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit(User user)//edit user
        {
            User User = users.Where(use => use.Id == user.Id).FirstOrDefault();
            if (User != null)
            {
                User.Name = user.Name;
                User.IsActive = user.IsActive;
            };
            return RedirectToAction("Get", users);
        }

        [HttpGet]
        [Route("Details")] // Display Details
        public IActionResult Details(int id)
        {
            User User = users.Where(use => use.Id.Equals(id)).Select(u => u).FirstOrDefault();
            return View(User);
        }

        [Route("Delete")]//delete not working
        public IActionResult Delete(int id)
        {
            User user = users.Find(use => use.Id == id);
            if (user != null)
            {
                users.Remove(user);
                return RedirectToAction("Get");
            }
            
            return View("Get");

        }
    }
}
