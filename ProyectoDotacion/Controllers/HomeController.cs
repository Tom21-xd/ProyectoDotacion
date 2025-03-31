using System.Data;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProyectoDotacion.Data;
using ProyectoDotacion.Models;

namespace ProyectoDotacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HomeProcedimientos homeProcedimientos = new HomeProcedimientos();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var municipios = homeProcedimientos.GetMunicipiosIntitucion();
            return View(municipios);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetSedes()
        {
            var sedes = homeProcedimientos.GetSedes();
            return Json(sedes);
        }

    }
}
