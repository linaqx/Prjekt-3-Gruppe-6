using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixNet.ServiceLayer;
using FlixNet.Models;



namespace FlixNet.Controllers
{

    public class HomeController : Controller
    {
        //foran en metode kan der skrives []httpPost
        private EntertainmentService eS;
        private LogInService lis;
        //private Entertainment entertainment;
        public HomeController()
        {
            eS = new EntertainmentService();
            lis = new LogInService();

        }


        public ActionResult Index()
        {
            List<Entertainment> entertainments;

            entertainments = eS.GetEntertainments();

            return View(entertainments);
        }

        public ActionResult Movies()
        {

            if (Session["user_id"] != null)
            {
                ViewBag.Message = "Your application description page.";
                return View();
            }
            else
            {
                return View("LogIn");
            }

        }

        public ActionResult Friends()
        {
            if (Session["user_id"] != null)
            {
                ViewBag.Message = "Your contact page.";
                return View();
            }
            else
            {
                return View("LogIn");
            }
        }

        public ActionResult Series()
        {
            if (Session["user_id"] != null)
            {
                ViewBag.Message = "Your contact page.";
                return View();
            }
            else
            {
                return View("LogIn");
            }
        }

        public ActionResult MyList()
        {
            if (Session["user_id"] != null)
            {
                List<FavoriteList> favoriteLists = eS.GetFavoriteLists((int)Session["user_id"]);

                return View(favoriteLists);

            }
            else
            {
                return View("LogIn");
            }

        }

        public ActionResult LogIn()
        {
            if (Session["user_id"] == null)
            {
                ViewBag.Message = "Your contact page.";
                return View();
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        public ActionResult Login(string UserName, string Password)
        {

            User user = new User
            {
                UserName = UserName,
                Password = Password
            };

            User userNew = lis.Login(user);

            Session["user_id"] = userNew.Id;
            Session["userName"] = userNew.UserName;
            Session["session_id"] = userNew.Session.Session_id;


            if (Session["user_id"] != null)
            {
                List<Entertainment> entertainments;
                entertainments = eS.GetEntertainments();
                return View("Index", entertainments);
            }
            else
            {
                ViewBag.Message = "You need to log in";
                return View("LogIn");
            }

        }

        public ActionResult Logout()
        {
            try
            {
                lis.Logout((int)Session["user_id"]);

                if (Session["user_id"] != null)
                {
                    Session["user_id"] = null;
                }

                if (Session["session_id"] != null)
                {
                    Session["session_id"] = null;
                }

                if (Session["movie_id"] != null)
                {
                    Session["movie_id"] = null;
                }

                if (Session["userName"] != null)
                {
                    Session["userName"] = null;
                }
            }

            catch (Exception)
            {

                throw;
            }

            List<Entertainment> entertainments;

            entertainments = eS.GetEntertainments();

            return View("Index", entertainments);
        }


    }
}
