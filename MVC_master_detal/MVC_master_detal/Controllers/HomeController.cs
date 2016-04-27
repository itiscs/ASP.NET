using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_master_detal.Models;

namespace MVC_master_detal.Controllers
{
    public class HomeController : Controller
    {
        SoccerContext db = new SoccerContext();

        public ActionResult Index()
        {
            var players = db.Players.Include("Team");
            return View(players.ToList());
        }

        public ActionResult TeamDetails(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Team team = db.Teams.Include("Players").FirstOrDefault(t => t.Id == id);
            if (team == null)
            {
                return HttpNotFound();
            }
            return View(team);
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}