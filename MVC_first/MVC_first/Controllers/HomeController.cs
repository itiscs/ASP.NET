using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_first.Models;

namespace MVC_first.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour>12?"Доброе утро!":"Добрый день!";
            return View();
        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(Guest guest)
        {
            if (ModelState.IsValid)
                return View("Thanks", guest);
            else
                return View();
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}