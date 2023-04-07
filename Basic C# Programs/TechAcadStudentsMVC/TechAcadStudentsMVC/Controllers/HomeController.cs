using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page - The Tech Academy";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Michael",
                LastName = "Davidson"

            };
            return View(dayTimeInstructor);
        }
        
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1,
                    FirstName = "Tony",
                    LastName = "Piscasi"
                },
                 new Instructor
                {
                    Id = 2,
                    FirstName = "Antonina",
                    LastName = "Giamanco"
                },
                  new Instructor
                {
                    Id = 3,
                    FirstName = "Adam",
                    LastName = "Smortolia"
                }

            };
            return View(instructors);
        }
        
    }
}