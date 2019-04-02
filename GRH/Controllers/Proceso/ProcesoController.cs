using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GRH.Controllers.Proceso
{
    public class ProcesoController : Controller
    {
        // GET: Proceso
        public ActionResult ProcesoIndex()
        {
            return View();
        }
        public ActionResult SalidadeEmpleados()
        {
            return View();
        }
        public ActionResult CalculoNominas()
        {
            return View();
        }
        public ActionResult Vacaciones()
        {
            return View();
        }
        public ActionResult Permisos()
        {
            return View();
        }
        public ActionResult Licencias()
        {
            return View();
        }
    }
}