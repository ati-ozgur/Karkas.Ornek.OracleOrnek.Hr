using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.Ornek.OracleOrnek.Hr.Bs.Hr;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary.Hr;

namespace Karkas.Ornek.OracleOrnek.Hr.MvcApp.Controllers
{
    public class RegionsController : Controller
    {
        RegionsBs bs = new RegionsBs();
        //
        // GET: /Regions/

        public ActionResult Index()
        {
            var model = bs.SorgulaHepsiniGetir();
            return View(model);
        }

        //
        // GET: /Regions/Details/5

        public ActionResult Details(int id)
        {
            var model = bs.SorgulaRegionIdIle(id);
            return View(model);
        }

        //
        // GET: /Regions/Create

        public ActionResult Create()
        {
            Regions model = new Regions();
            return View(model);
        }

        //
        // POST: /Regions/Create

        [HttpPost]
        public ActionResult Create(Regions region)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bs.Ekle(region);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Regions/Edit/5

        public ActionResult Edit(int id)
        {
            var model = bs.SorgulaRegionIdIle(id);
            return View(model);
        }

        //
        // POST: /Regions/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Regions region)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bs.Guncelle(region);
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View(region);
            }
        }

        //
        // GET: /Regions/Delete/5

        public ActionResult Delete(int id)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bs.Sil(id);
                }
            }
            catch
            {
                ViewBag.Message = "Hata olustu";
            }

            return RedirectToAction("Index");
        }

    }
}
