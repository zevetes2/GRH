using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GRH.Models;

namespace GRH.Controllers.Informe
{
    public class InformeController : Controller
    {
        // GET: Informe
        public ActionResult InformeIndex()
        {
            return View();
        }
        public ActionResult EmpleadosActivos(String Nombre_Empleado)
        {
            using (GestionRecursosHumanosEntities db = new GestionRecursosHumanosEntities())
            {
                var emple = from s in db.empleado select s;
                if (!String.IsNullOrEmpty(Nombre_Empleado))
                {
                    emple = emple.Where(j => j.nombre.Contains(Nombre_Empleado));
                }
                return View(emple.ToList());
            }

        }
        public ActionResult EmpleadosInactivos()
        {
            return View();
        }
        public ActionResult Departamentos()
        {
            return View();
        }
        public ActionResult Cargos()
        {
            return View();
        }
        public ActionResult EntradaEmpleados()
        {
            return View();
        }
        public ActionResult SalidasEmpleados()
        {
            return View();
        }
        public ActionResult Permisos()
        {
            return View();
        }
    }
}