using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                // logic to calculate quote based on guidelines and conditions set forth
                decimal monthlyTotal = 50m; // base monthlyTotal quote = $50

                //age conditions logic
                int currentYear = DateTime.Now.Year; // current year
                DateTime insureeDob = insuree.DateOfBirth; // get DOB from insurees db table info, store in var insureeDob
                int insureeDobYear = insureeDob.Year; // gets insurees year of birth, stores in var insureeDobYear
                int insureeAge = currentYear - insureeDobYear; // get insuree age by subtracting current year from insurree's Dob year , stores in var insureeAge

                if (insureeAge <= 18) // age 18 or less
                {
                    monthlyTotal += 100m; // add $100 to monthly total
                }
                if (insureeAge >= 19 && insureeAge <= 25) //ages 19 to 25
                {
                    monthlyTotal += 50m; // adds $50 to monthly total
                }
                if (insureeAge >= 26) // age 26 or greater
                {
                    monthlyTotal += 25m; // adds $25 to montly total
                }
                if (insuree.CarYear < 2000) //car year before 2000
                {
                    monthlyTotal += 25m; // add $25 to monthly total 
                }
                if (insuree.CarYear > 2015) // for car years after 2015
                {
                    monthlyTotal += 25; // add $25 to monthly total 
                }
                if (insuree.CarMake == "Porsche") // for car make "Porsche"
                {
                    monthlyTotal += 25m; // add $25 to monthly total
                }
                if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carerra" )
                {
                    monthlyTotal += 25m; // add $25 to monthly total
                }
                if (insuree.SpeedingTickets > 0)
                {
                    int ticketnumber = insuree.SpeedingTickets;
                    monthlyTotal += ticketnumber * 10m; // add $10 per ticket to monthly total 
                }
                if (insuree.DUI == true)
                {
                    monthlyTotal += monthlyTotal * 0.25m; // adds 25% of monthly total quote, to the quote
                }
                if (insuree.CoverageType == true)
                {
                    monthlyTotal += monthlyTotal * 0.50m; // adds 50% of monthly total quote, to the quote
                }
                insuree.Quote = monthlyTotal; // returns monthly quote total to the insuree db, sets Quote field 

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Admin() // Admin view quotes page
        {
            return View(db.Insurees.ToList());
        }
    }
}
