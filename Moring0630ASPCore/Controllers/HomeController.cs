using Microsoft.AspNetCore.Mvc;
using Moring0630ASPCore.Models;
using Moring0630ASPCore.Services;
using System.Diagnostics;

namespace Moring0630ASPCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFloorService _service;

        public HomeController(IFloorService service, ILogger<HomeController> logger)
        {

            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            var model = _service.GetFloors();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}