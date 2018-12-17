using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixNet.Models;
using FlixNet.ServiceLayer;
/// <summary>
/// @Author: Group 6: Andreas L, Katrine M, Mathias L
/// @Version: 17-12-2018
/// </summary>

namespace FlixNet.Controllers
{
    public class MovieController : Controller
    {
        private EntertainmentService eS;

        /// <summary>
        /// Constructor for MovieController
        /// </summary>
        public MovieController()
        {
            eS = new EntertainmentService();
        }

        /// <summary>
        /// Actionresult for Viwe Index(in Movie views)
        /// </summary>
        /// <param name="message"></param>
        /// <returns>View();</returns>
        public ActionResult Index(string message)
        {
            return View();
        }

        /// <summary>
        /// Actionresult for Movie2
        /// </summary>
        /// <param name="MovieId"></param>
        /// <returns>View(movie);</returns>
        [HttpPost]
        public ActionResult Movie2(int MovieId)
        {
            if (Session["user_id"] != null)
            {
                Movie movie = eS.GetMovieById(MovieId);
                Session["movie_id"] = movie.Id;
                return View(movie);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        /// <summary>
        /// Actionresult for AddComment, creates a comment object adds et to the movie object
        /// </summary>
        /// <param name="message"></param>
        /// <returns>View("Movie2", movie);</returns>
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

            return View("Movie2", movie);
        }
    }
}