﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FlixNet.Models;
using FlixNet.ServiceLayer;

namespace FlixNet.Controllers
{
    public class MovieController : Controller
    {
        private EntertainmentService eS;

        public MovieController()
        {
            eS = new EntertainmentService();
        }
        public ActionResult Index(string message)
        {
            //FormMethod.Post(string )
            HttpGetAttribute httpGetAttribute;

            //insert comment skal ske herfra
            return View();
        }

        [HttpPost]
        public ActionResult Movie2(int MovieId)
        {
            Movie movie = eS.GetMovieById(MovieId);

            return View(movie);

        }


        public ActionResult Movie2(string CommentData, string CommentMovieId)
        {

            string x = CommentData + "test" + CommentMovieId;


            return View();
        }

        // GET: Movie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movie/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Movie/Edit/5
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

        // GET: Movie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Movie/Delete/5
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