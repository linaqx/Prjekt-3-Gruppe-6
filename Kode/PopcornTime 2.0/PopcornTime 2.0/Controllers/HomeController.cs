using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PopcornTime_2._0.ServiceLayer;
using PopcornTime_2._0.Models;
using Microsoft.AspNet.Identity;


namespace PopcornTime_2._0.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //foran en metode kan der skrives []httpPost
        private EntertainmentService eS;
        //private Entertainment entertainment;
        public HomeController()
        {
            eS = new EntertainmentService();
            //entertainment = new Entertainment();
        }

        
        public ActionResult Index()
        {
            List<Entertainment> entertainments;
            
            entertainments = eS.GetEntertainments();
            //Entertainment entertainment = new Entertainment(string title, DateTime releaseDate);
            //Entertainment[] ents;

            //using (var client = new TimeSlotServiceClient())
            //{
            //    tSlots = await client.FindAllUnoccupiedAsync();
            //}

            //return View(tSlots.ToList());
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

        //public ActionResult Movie1()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
        public ActionResult Movie2()
        {
            ViewBag.Message = "Your contact page.";
            Movie movie;

            movie = eS.MovieById(1);
            return View(movie);
        }

        public ActionResult MyListPartialView()
        {
            ViewBag.Message = "Your contact page.";
            PartialView("MyListPartialView");

            return View();
        }

        public ActionResult AddComment(Comment c)
        {
            //some operations goes here


            return Movie2(); //return some view to the user
        }
    }
}