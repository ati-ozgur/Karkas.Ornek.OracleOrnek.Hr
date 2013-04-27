using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.Ornek.OracleOrnek.Hr.Bs.Hr;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary.Hr;

namespace Karkas.Ornek.OracleOrnek.Hr.MvcApp.Controllers
{
    public class CountriesController : Controller
    {
        //
        // GET: /Countries/

        CountriesBs bs = new CountriesBs();

        public ActionResult Index()
        {
            var model = bs.SorgulaHepsiniGetir();
            return View(model);
        }

        //
        // GET: /Countries/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Countries/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Countries/Create

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

        //
        // GET: /Countries/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Countries/Edit/5

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

        //
        // GET: /Countries/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Countries/Delete/5

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
