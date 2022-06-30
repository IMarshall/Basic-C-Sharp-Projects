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
                insuree.Quote = CalculateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        //CALCULATE QUOTE
        public decimal CalculateQuote(Insuree insuree)
        {
            decimal quote = 50;

            //CALCULATE AGE
            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;

            //IF THEY HAVEN'T HAD THEIR BIRTHDAY THIS YEAR, ADJUST THEIR AGE
            if(DateTime.Now.DayOfYear < insuree.DateOfBirth.DayOfYear)
            {
                age -= 1;
            }

            //ADJUST QUOTE BASED ON AGE
            if(age <= 18)
            {
                quote += 100;
            }
            else if(age >= 19 && age <= 25)
            {
                quote += 50;
            }
            else
            {
                quote += 25;
            }

            //ADJUST QUOTE BASED ON CAR YEAR
            if(insuree.CarYear < 2000)
            {
                quote += 25;
            }
            else if(insuree.CarYear > 2015)
            {
                quote += 25;
            }

            //ADJUST QUOTE BASED ON CAR MAKE
            if(insuree.CarMake.ToLower() == "porsche")
            {
                quote += 25;

                if(insuree.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                }
            }

            //ADJUST QUOTE BASED ON SPEEDING TICKETS
            if(insuree.SpeedingTickets > 0)
            {
                quote += insuree.SpeedingTickets * 10;
            }

            if (insuree.DUI)
            {
                quote *= 1.25m;
            }

            if (insuree.CoverageType)
            {
                quote *= 1.5m;
            }

            return quote;
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
    }
}
