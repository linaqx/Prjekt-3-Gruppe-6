using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PopcornTime_2._0.EntertainmentService1
{
    public class EntertainmentController : Controller
    {
        // GET: Entertainment
        public ActionResult Index()
        {
            return View();
        }

        // GET: Entertainment/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Entertainment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entertainment/Create
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

        // GET: Entertainment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Entertainment/Edit/5
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

        // GET: Entertainment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Entertainment/Delete/5
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
