using CornerStoneApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CornerStoneApp2.Controllers
{
    public class AdvocateRegisterController : Controller
    {
        // GET: AdvocateRegister
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdvocateRegister/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdvocateRegister/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdvocateRegister/Create
        [HttpPost]
        public ActionResult Create(Advocate advocate)
        {
            try
            {
                var db = new ApplicationContext();
                db.Advocates.Add(advocate);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdvocateRegister/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdvocateRegister/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdvocateRegister/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdvocateRegister/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
