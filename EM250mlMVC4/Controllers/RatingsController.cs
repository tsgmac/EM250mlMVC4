using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM250mlMVC4.Models;

namespace EM250mlMVC4.Controllers
{
    public class RatingsController : Controller
    {
        private EventsAndRatings db = new EventsAndRatings();

        //
        // GET: /Ratings/

        public ActionResult Index()
        {
            return View(db.RatingsDbSet.ToList());
        }

        //
        // GET: /Ratings/Details/5

        public ActionResult Details(int id = 0)
        {
            Ratings ratings = db.RatingsDbSet.Find(id);
            if (ratings == null)
            {
                return HttpNotFound();
            }
            return View(ratings);
        }

        //
        // GET: /Ratings/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Ratings/Create

        [HttpPost]
        public ActionResult Create(Ratings ratings)
        {
            if (ModelState.IsValid)
            {
                db.RatingsDbSet.Add(ratings);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ratings);
        }

        //
        // GET: /Ratings/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Ratings ratings = db.RatingsDbSet.Find(id);
            if (ratings == null)
            {
                return HttpNotFound();
            }
            return View(ratings);
        }

        //
        // POST: /Ratings/Edit/5

        [HttpPost]
        public ActionResult Edit(Ratings ratings)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ratings).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ratings);
        }

        //
        // GET: /Ratings/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Ratings ratings = db.RatingsDbSet.Find(id);
            if (ratings == null)
            {
                return HttpNotFound();
            }
            return View(ratings);
        }

        //
        // POST: /Ratings/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Ratings ratings = db.RatingsDbSet.Find(id);
            db.RatingsDbSet.Remove(ratings);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}