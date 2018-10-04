using Control_asistencia_mvc.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Control_asistencia_mvc.Controllers
{
    public class CargoController : Controller
    {  private AsistenciaEntities db = new AsistenciaEntities();
        // GET: Cargo
        public ActionResult Index()
        {
            ViewBag.Cargos = db.cargos.ToList();

            return View();
        }

        // GET: Cargo/Details/5
        public ActionResult Details(int? id)
        {
             if (id == null) {
                return new HttpStatusCodeResult (HttpStatusCode.BadRequest);
            }

            var cargos = db.cargos.Find(id);
            if (cargos == null)
            {
                return HttpNotFound();
            }

            return View(cargos);
        }

        // GET: Cargo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cargo/Create
        [HttpPost]
        public ActionResult Create(cargos cargos)
        {
            try
            { 
                if (ModelState.IsValid)
                {      
                    db.cargos.Add(cargos);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(cargos);
            }
            catch 
            {
                return View(cargos);
            }
        }

        // GET: Cargo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var cargos = db.cargos.Find(id);
            if (cargos == null)
            {
                return HttpNotFound();
            }

            return View(cargos);
        }

        // POST: Cargo/Edit/5
        [HttpPost]
        public ActionResult Edit(cargos cargos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(cargos).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(cargos);
            }
            catch
            {
                return View(cargos);
            }
        }

        // GET: Cargo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cargo/Delete/5
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
