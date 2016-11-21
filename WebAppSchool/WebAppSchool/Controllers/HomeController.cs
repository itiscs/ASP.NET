﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppSchool.Models;
using WebAppSchool.ViewModels;

namespace WebAppSchool.Controllers
{
    public class HomeController : Controller
    {
        private SchoolDB db = new SchoolDB();
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentDateGroup> 
                data = from student in db.Students
           group student by student.EnrollmentDate into dateGroup
                       select new EnrollmentDateGroup()
                      {
                            EnrollmentDate = dateGroup.Key,
                            StudentCount = dateGroup.Count()
                       };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}