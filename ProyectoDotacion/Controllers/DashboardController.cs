using Microsoft.AspNetCore.Mvc;
using ProyectoDotacion.Data;

namespace ProyectoDotacion.Controllers
{
    public class DashboardController : Controller
    {
        public DashboardProcedimientos Dp = new DashboardProcedimientos();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getZonas() { 
            var zonas = Dp.getZonas();
            return Json(zonas);
        }

        [HttpGet]
        public JsonResult getCantidadSede()
        {
            var instituciones = Dp.getCantidadSede();
            return Json(instituciones);
        }
        [HttpGet]
        public JsonResult getinstitucionarticulo()
        {
            var artic= Dp.getinstitucionarticulo();
            return Json(artic);

        }
    }
}
