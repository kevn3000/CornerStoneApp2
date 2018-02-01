using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CornerStoneApp2.DAL;
using CornerStoneApp2.Models;

namespace CornerStoneApp2.Controllers
{
    public class AdvoController : Controller
    {
        private CornerstoneContext db = new CornerstoneContext();

        // GET: Advo
        public ActionResult Index()
        {
            return View(db.Advocates.ToList());
        }

        // GET: Advo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advo advo = db.Advocates.Find(id);
            if (advo == null)
            {
                return HttpNotFound();
            }
            return View(advo);
        }

        // GET: Advo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advo/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FirstName,LastName")] Advo advo)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Advocates.Add(advo);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator");

            }
            return View(advo);
        }

        // GET: Advo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advo advo = db.Advocates.Find(id);
            if (advo == null)
            {
                return HttpNotFound();
            }
            return View(advo);
        }

        // POST: Advo/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AdvoID,FirstName,LastName")] Advo advo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(advo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(advo);
        }

        // GET: Advo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Advo advo = db.Advocates.Find(id);
            if (advo == null)
            {
                return HttpNotFound();
            }
            return View(advo);
        }

        // POST: Advo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Advo advo = db.Advocates.Find(id);
            db.Advocates.Remove(advo);
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
