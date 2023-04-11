using NewsletterApp465.Models;
using NewsletterApp465.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterApp465.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsletterEntities db = new NewsletterEntities()) // instantiate newsletterentities object that gives us access to the database db
            {
                // here we grab all the signups with remove property == to null from the db
                //var signups = db.Signups.Where(x => x.Removed == null).ToList(); //in Lambda or below
                var signups = (from c in db.Signups     // same as above but in LINQ vs Lambda
                               where c.Removed == null
                               select c).ToList();

                var signupVms = new List<SignupVm>(); // create a list of view models
                foreach (var signup in signups) // loop through the models and map them below to the view model
                {
                    var signupVm = new SignupVm();  // instantiate new instance 
                    signupVm.Id = signup.Id;        // maping properties to each other
                    signupVm.FirstName = signup.FirstName;  
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);

                }


                return View(signupVms);
            }
        }
    public ActionResult Unsubscribe(int Id)
        {
            using (NewsletterEntities db = new NewsletterEntities()) // auto creates connection to db
            {
                var signup = db.Signups.Find(Id); // finds entity with thegiven primary key values - ID is the key
                signup.Removed = DateTime.Now; // change the property to datetime instead of null
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }
    }
}