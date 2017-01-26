using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Angular2Mvc5Application1.Controllers
{
    public class PhotoJobController : Controller
    {
        // GET: PhotoJob
        public string Index()
        {
            var repo = new Models.DAL.RealEstateJobRepository();
            var jobs = repo.GetJobs();
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(jobs);
            return json;
        }

        // GET: PhotoJob/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PhotoJob/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhotoJob/Create
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

        // GET: PhotoJob/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PhotoJob/Edit/5
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

        // GET: PhotoJob/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PhotoJob/Delete/5
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
