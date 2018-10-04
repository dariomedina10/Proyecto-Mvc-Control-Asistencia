using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TipoEmpleado/Edit/5
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
