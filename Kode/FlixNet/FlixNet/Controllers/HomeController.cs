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

            List<FavoriteList> favoriteLists = eS.GetFavoriteLists(1);


            return View(favoriteLists);
        }

        [HttpPost]
        public ActionResult AddComment(string message)
        {
            Session session = new Session
            {
                Session_id = (string)Session["session_id"]
            };

            User user = new User
            {
                Id = (int)Session["user_id"],
                Session = session
            };

            Comment comment = new Comment
            {
                Message = message,
                Entertainment_Id = (int)Session["movie_id"],
                User = user
            };


            eS.InsertComment(comment);

            Movie movie = eS.GetMovieById((int)Session["movie_id"]);
            Session["movie_id"] = movie.Id;

            return View("Movie2", movie); //return some view to the user
        }

        public ActionResult LogIn()
        {
            return View();
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


            if(Session["user_id"] != null)
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
            return View("Index");
        }


    }
}
