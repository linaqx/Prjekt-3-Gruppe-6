using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Projekt_3___Web_Client.ServiceLayer;
using Projekt_3___Web_Client.Models;

namespace Projekt_3___Web_Client.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Entertainment> entertainments = new List<Entertainment>();
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