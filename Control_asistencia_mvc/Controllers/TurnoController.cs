﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Turno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Turno/Create
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

        // GET: Turno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Turno/Edit/5
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
