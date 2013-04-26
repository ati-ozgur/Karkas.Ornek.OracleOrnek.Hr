using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Karkas.Ornek.OracleOrnek.Hr.Bs.Hr;
using Karkas.Ornek.OracleOrnek.Hr.TypeLibrary.Hr;

namespace Karkas.Ornek.OracleOrnek.Hr.MvcApp.Controllers
{
    public class DepartmentsController : Controller
    {
        DepartmentsBs bs = new DepartmentsBs();
        //
        // GET: /Departments/

        public ActionResult Index()
        {
            var model = bs.SorgulaHepsiniGetir();
            return View(model);
        }

        //
        // GET: /Departments/Details/5

        public ActionResult Details(int id)
        {
            var model = bs.SorgulaDepartmentIdIle(id);

            return View(model);
        }

        //
        // GET: /Departments/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Departments/Create

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
        // GET: /Departments/Edit/5

        public ActionResult Edit(int id)
        {
            var model = bs.SorgulaDepartmentIdIle(id);

            return View(model);

        }

        //
        // POST: /Departments/Edit/5

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
        // GET: /Departments/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Departments/Delete/5

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
