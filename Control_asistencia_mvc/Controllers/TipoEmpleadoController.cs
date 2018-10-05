using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Control_asistencia_mvc.Controllers
{
    public class TipoEmpleadoController : Controller
    {
        private AsistenciaEntities db = new AsistenciaEntities();
        // GET: TipoEmpleado
        public ActionResult Index()
        {
            ViewBag.Tipoempleado = db.tipo_empleado.ToList();
            return View();
        }

        // GET: TipoEmpleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tipo_empleado = db.tipo_empleado.Find(id);
            if (tipo_empleado == null)
            {
                return HttpNotFound();
            }

            return View(tipo_empleado);
        }

        // GET: TipoEmpleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoEmpleado/Create
        [HttpPost]
        public ActionResult Create(tipo_empleado tipo_Empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.tipo_empleado.Add(tipo_Empleado);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tipo_Empleado);
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoEmpleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var tipo_empleado = db.tipo_empleado.Find(id);
            if (tipo_empleado == null)
            {
                return HttpNotFound();
            }

            return View(tipo_empleado);
        }

        // POST: TipoEmpleado/Edit/5
        [HttpPost]
        public ActionResult Edit(tipo_empleado tipo_Empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(tipo_Empleado).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(tipo_Empleado);
            }
            catch
            {
                return View(tipo_Empleado);
            }

        }

        // GET: TipoEmpleado/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TipoEmpleado/Delete/5
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
