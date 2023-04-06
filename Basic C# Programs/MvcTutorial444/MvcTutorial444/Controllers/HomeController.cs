using MvcTutorial444.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcTutorial444.Controllers
{
    public class HomeController : Controller  // HomeController is the "Home" page in the web address bar. So www.websiteneame.com/home <-- routes to the HomeController
    {
        public ActionResult Index() // Method
        {

            User user = new User();
            user.Id = 1;
            user.FirstName = "Michael";
            user.LastName = "David";
            user.Age = 44;

            return View(user);

            //int number = 5;
            //return View(number);

            //List<string> names = new List<string>
            //{
            //    "Michael",
            //    "Jesse",
            //    "Adam"
            //};
            //return View(names);

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


//// public ActionResult Index() // Method
//{


//    return View();


//    //string text = "Hello";
//    //System.IO.File.WriteAllText(@"C:\Users\Michael\Logs\sample.log.txt", text);

//    //Random random = new Random(10);
//    //var num = random.Next(); //int using the "var" shortcut

//    ////ViewBag.RandomNumber = num;

//    //if (num > 20000)
//    //{
//    //    return View("About"); // returns the About page bc it is inside of this controller, MVC knows what to do...and will return it
//    //}

//    //return Content("About"); //returns the "content in string form or " " nothing if needed

//    //return RedirectToAction("Contact"); //redirect to "Contact" page whereas addding contact to View like we did add would not change the url like this does
//}