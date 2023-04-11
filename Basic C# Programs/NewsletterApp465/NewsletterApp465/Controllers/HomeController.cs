using NewsletterApp465.Models;
using NewsletterApp465.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NewsletterApp465.Controllers
{
    public class HomeController : Controller
    {
    
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, String lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) 
            {
                return View("~/Views/Shared/Error.cshtml");

            }
            else
            {
                //ADO.NET --google syntax if or when needed
                //DB Name (Newqsletter) in VIEW/ SQL SERVER OBJECT EXPLORER:  r click ON Properties/ FIND Conection String IN General/ Copy /Paste INSIDE @ ""(QUOTES)
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new Signup();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    

                    db.Signups.Add(signup);
                    db.SaveChanges();
                }
                
                    return View("Success");
            }

        }
       
        
    }
}