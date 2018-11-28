using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projekt_3___Web_Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult MyList()
        {
            return View();
        }

        public ActionResult Movies()
        {
            return View();
        }

        public ActionResult Series()
        {
            return View();
        }

        public ActionResult Friends()
        {
            return View();
        }
        // Skal måske fjernes 
        public ActionResult Search()
        {
            return View();
            
        }

        
    }
}