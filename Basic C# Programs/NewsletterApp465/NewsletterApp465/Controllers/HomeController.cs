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
        private readonly string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Newsletter;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

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
                


                    //string queryString = @"INSERT INTO SignUps (FirstName, LastName, EmailAddress) VALUES 
                    //                      (@FirstName, @LastName, @EmailAddress)"; // always pass info into your SQL with parameters as such, never directly, this moslty avoids SQL injections (hacks)

                    //using (SqlConnection connection = new SqlConnection(connectionString)) // when opening an outside server always wrap it in a "using" statement like this so
                    //                                                                       // that it gets cutoff and there are no memory leaks or slowdowns
                    //{
                    //    SqlCommand command = new SqlCommand(queryString, connection);
                    //    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    //    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);

                    //    command.Parameters["@FirstName"].Value = firstName;
                    //    command.Parameters["@LastName"].Value = lastName;
                    //    command.Parameters["@EmailAddress"].Value = emailAddress;

                    //    connection.Open();
                    //    command.ExecuteNonQuery();
                    //    connection.Close();
                    //}
                    return View("Success");
            }

        }
       
        public ActionResult Admin()
        {   

            using (NewsletterEntities db = new NewsletterEntities()) // instantiate newsletterentities object that gives us access to the database db
            {
                var signups = db.Signups; 
                var signupVms = new List<SignupVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignupVm();
                    signupVm.FirstName = signup.FirstName;  // maping properties to each other
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVms.Add(signupVm);

                }


                return View(signupVms);
            }


            // all of this was eliminated by using Entity Data Model.edmx 
            //string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, SocialSecurityNumber from Signups";
            //List<NewsletterSignUp> signups = new List<NewsletterSignUp>();

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    SqlCommand command = new SqlCommand(queryString, connection);

            //    connection.Open();

            //    SqlDataReader reader = command.ExecuteReader();

            //    while (reader.Read())
            //    {
            //        var signup = new NewsletterSignUp();
            //        signup.Id = Convert.ToInt32(reader["Id"]);
            //        signup.FirstName = reader["FirstName"].ToString();
            //        signup.LastName = reader["LastName"].ToString();
            //        signup.EmailAddress = reader["EmailAddress"].ToString();
            //        signup.SocialSecurityNumber = reader["SocialSecurityNumber"].ToString();
            //        signups.Add(signup);

            //    }
            //}
            
        }
    }
}