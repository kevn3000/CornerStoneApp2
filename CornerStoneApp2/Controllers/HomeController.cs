using CornerStoneApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CornerStoneApp2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var x = new ApplicationContext();
            var advocates = x.Advocates.Where(y => true);
               
            return View(new Advocate());
        }

        [HttpPost]
        public ActionResult Index(Advocate advocate) {

            var x = new ApplicationContext();
            var advocates = x.Advocates.First(y => y.MyId == advocate.MyId);
            advocates.Tasks = advocate.Tasks;
            x.SaveChanges();
            return View(advocates);
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