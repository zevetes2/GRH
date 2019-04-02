using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRH.Controllers.Informe
{
    public class InformeController : Controller
    {
        // GET: Informe
        public ActionResult InformeIndex()
        {
            return View();
        }
        public ActionResult EmpleadosActivos()
        {
            return View();
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