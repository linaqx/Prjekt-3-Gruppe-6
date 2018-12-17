using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixNet.ServiceLayer;
using FlixNet.Models;

/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>

namespace FlixNet.Controllers
{
    public class HomeController : Controller
    {
        private EntertainmentService eS;
        private LogInService lis;

        /// <summary>
        /// Constructor for Homecontroller
        /// </summary>
        public HomeController()
        {
            eS = new EntertainmentService();
            lis = new LogInService();
        }

        /// <summary>
        /// Actionresult for Index view
        /// </summary>
        /// <returns>View(entertainments);</returns>
        public ActionResult Index()
        {
            List<Entertainment> entertainments;
            entertainments = eS.GetEntertainments();
            return View(entertainments);
        }
        /// <summary>
        /// Actionresult for Movies view
        /// </summary>
        /// <returns>
        /// View();
        /// View("LogIn");
        /// </returns>
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

        /// <summary>
        /// Actionresult for Friends View
        /// </summary>
        /// <returns>
        /// View(); If user is logged in
        /// View("LogIn"); If user isen't logged in
        /// </returns>
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

        /// <summary>
        /// Actionresult for view Series
        /// <returns>
        /// View(); If user is logged in
        /// View("LogIn"); If user isen't logged in
        /// </returns>
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

        /// <summary>
        /// Actionresult for view MyList
        /// </summary>
        /// <returns>
        /// View(favoriteLists) If user is logged in
        /// View() If user is not
        /// </returns>
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

        /// <summary>
        /// Actionresult for view LogIn
        /// </summary>
        /// <returns>
        /// View(); If user is not logged in 
        /// View("Index") if user is logged in
        /// </returns>
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

        /// <summary>
        /// Takes input string UserName, string password from LogIn view, checks if user exist in database
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Password"></param>
        /// <returns>View("Index", entertainments);</returns>
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

        /// <summary>
        /// Action result for logout
        /// </summary>
        /// <returns>View("Index", entertainments);</returns>
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
