using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOCSeafood.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SOCSeafood.Controllers
{
    public class SubscribersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize]
        public IActionResult Index()
        {
            return View(db.Subscribers.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Subscriber subscriber)
        {
            db.Subscribers.Add(subscriber);
            db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
