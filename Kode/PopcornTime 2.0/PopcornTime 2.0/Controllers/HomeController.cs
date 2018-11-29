using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PopcornTime_2._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Movies()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Friends()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Series()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyList()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}