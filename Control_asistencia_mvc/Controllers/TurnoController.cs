using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Control_asistencia_mvc.Controllers
{
    
    public class TurnoController : Controller
    {
        private AsistenciaEntities db = new AsistenciaEntities();
        // GET: Turno
        public ActionResult Index()
        {
            ViewBag.Turnos = db.turnos.ToList();
            return View();
        }

        // GET: Turno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var turnos = db.turnos.Find(id);
            if (turnos == null)
            {
                return HttpNotFound();
            }

            return View(turnos);
        }

        // GET: Turno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turno/Create
        [HttpPost]
        public ActionResult Create(turnos turnos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.turnos.Add(turnos);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(turnos);
            }
            catch
            {
                return View();
            }
        }

        // GET: Turno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var turnos = db.turnos.Find(id);
            if (turnos == null)
            {
                return HttpNotFound();
            }

            return View(turnos);
        }

        // POST: Turno/Edit/5
        [HttpPost]
        public ActionResult Edit(turnos turnos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(turnos).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(turnos);
            }
            catch
            {
                return View(turnos);
            }

        }

        // GET: Turno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Turno/Delete/5
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
