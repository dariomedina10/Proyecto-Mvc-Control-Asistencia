using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ControlAsistencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControlAsistencia/Create
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

        // GET: ControlAsistencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControlAsistencia/Edit/5
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

        // GET: ControlAsistencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControlAsistencia/Delete/5
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
