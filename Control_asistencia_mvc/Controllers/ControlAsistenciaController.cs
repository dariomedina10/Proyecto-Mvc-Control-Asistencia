using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Control_asistencia_mvc.Controllers
{
    public class ControlAsistenciaController : Controller
    {
        private AsistenciaEntities db = new AsistenciaEntities();
        // GET: ControlAsistencia
        public ActionResult Index()
        {
            ViewBag.controlasistencia = db.control_asistencia.ToList();
            return View();
        }

        // GET: ControlAsistencia/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var control_asistencia = db.control_asistencia.Find(id);
            if (control_asistencia == null)
            {
                return HttpNotFound();
            }

            return View(control_asistencia);
        }

        // GET: ControlAsistencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControlAsistencia/Create
        [HttpPost]
        public ActionResult Create(control_asistencia control_Asistencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.control_asistencia.Add(control_Asistencia);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(control_Asistencia);
            }
            catch
            {
                return View();
            }
        }

        // GET: ControlAsistencia/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var control_asistencia = db.control_asistencia.Find(id);
            if (control_asistencia == null)
            {
                return HttpNotFound();
            }

            return View(control_asistencia);
        }

        // POST: ControlAsistencia/Edit/5
        [HttpPost]
        public ActionResult Edit(control_asistencia control_Asistencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(control_Asistencia).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(control_Asistencia);
            }
            catch
            {
                return View(control_Asistencia);
            }
        }

        // GET: ControlAsistencia/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var control_asistencia = db.control_asistencia.Find(id);
            if (control_asistencia == null)
            {
                return HttpNotFound();
            }

            return View(control_asistencia);

        }

        // POST: ControlAsistencia/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, control_asistencia control_Asistencia)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    control_Asistencia = db.control_asistencia.Find(id);
                    if (control_Asistencia == null)
                    {
                        return HttpNotFound();
                    }

                    db.control_asistencia.Remove(control_Asistencia);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(control_Asistencia);
            }
            catch
            {
                return View(control_Asistencia);
            }
    }
}
    }

