using System;
using System.Data;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GRH.Models;

namespace GRH.Controllers.Mantenimiento.Empleado
{
    public class EmpleadoController : Controller
    {
        private GestionRecursosHumanosEntities db = new GestionRecursosHumanosEntities();
        // GET: Empleado
        public ActionResult IndexEmpleado()
        {

            return View();
        }
        public ActionResult CrearEmpleado()
        {
            ViewBag.cargo = new SelectList(db.cargo, "codigo_cargo", "nombre_cargo");
            ViewBag.departamento = new SelectList(db.departamento, "codigo_departamento", "nombre");
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CrearEmpleado([Bind(Include = "codigo_empleado,nombre,apellido,telefono,departamento,cargo,fecha_ingreso,salario,estatus")] empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.empleado.Add(empleado);
                db.SaveChanges();
                return Redirect("~/Informe/EmpleadosActivos");
            }

            ViewBag.cargo = new SelectList(db.cargo, "codigo_cargo", "nombre_cargo", empleado.cargo);
            ViewBag.departamento = new SelectList(db.departamento, "codigo_departamento", "nombre", empleado.departamento);
            return View(empleado);
        }
        public ActionResult EditarEmpleado(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empleado empleado = db.empleado.Find(id);
            if (empleado == null)
            {
                return HttpNotFound();
            }
            ViewBag.cargo = new SelectList(db.cargo, "codigo_cargo", "nombre_cargo", empleado.cargo);
            ViewBag.departamento = new SelectList(db.departamento, "codigoDepartamento", "nombre", empleado.departamento);
            return View(empleado);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarEmpleado([Bind(Include = "codigo_empleado,nombre,apellido,telefono,departamento,cargo,fecha_ingreso,salario,estatus")] empleado empleado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empleado).State = EntityState.Modified;
                db.SaveChanges();
                return Redirect("~/Informe/EmpleadosActivos");
            }
            ViewBag.cargo = new SelectList(db.cargo, "codigo_cargo", "nombre_cargo", empleado.cargo);
            ViewBag.departamento = new SelectList(db.departamento, "codigoDepartamento", "nombre", empleado.departamento);
            return View(empleado);
        }
        public ActionResult EliminarEmpleado()
        {
            return View();
        }
    }
}