﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Control_asistencia_mvc.Controllers
{
    public class EmpleadoController : Controller
    {
        private AsistenciaEntities db = new AsistenciaEntities();

        // GET: Empleado
        public ActionResult Index()
        {
            ViewBag.empleados = db.empleados.ToList();
            return View();
        }

        // GET: Empleado/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var empleados = db.empleados.Find(id);
            if (empleados == null)
            {
                return HttpNotFound();
            }

            return View(empleados);
        }

        // GET: Empleado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Empleado/Create
        [HttpPost]
        public ActionResult Create(empleados empleados)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.empleados.Add(empleados);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(empleados);
            }
            catch
            {
                return View();
            }
        }

        // GET: Empleado/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var empleados = db.empleados.Find(id);
            if (empleados == null)
            {
                return HttpNotFound();
            }

            return View(empleados);
        }

        // POST: Empleado/Edit/5
        [HttpPost]
        public ActionResult Edit(empleados empleados)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(empleados).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(empleados);
            }
            catch
            {
                return View(empleados);
            }

        }

        // GET: Empleado/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var empleados = db.empleados.Find(id);
            if (empleados == null)
            {
                return HttpNotFound();
            }

            return View(empleados);
        }

        // POST: Empleado/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id, empleados empleados)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    empleados = db.empleados.Find(id);
                    if (empleados == null)
                    {
                        return HttpNotFound();
                    }

                    db.empleados.Remove(empleados);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(empleados);
            }
            catch
            {
                return View(empleados);
            }
        }
    }
}
