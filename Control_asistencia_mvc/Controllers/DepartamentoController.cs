using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Control_asistencia_mvc.Controllers
{
    public class DepartamentoController : Controller
    {
        private AsistenciaEntities db = new AsistenciaEntities();
        // GET: Departamento
        public ActionResult Index()
        {
            ViewBag.Departamentos = db.departamentos.ToList();
            return View();
        }

        // GET: Departamento/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Departamento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Departamento/Create
        [HttpPost]
        public ActionResult Create(departamentos departamentos)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.departamentos.Add(departamentos);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(departamentos);
            }
            catch
            {
                return View();
            }
        }

        // GET: Departamento/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Departamento/Edit/5
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

        // GET: Departamento/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Departamento/Delete/5
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
