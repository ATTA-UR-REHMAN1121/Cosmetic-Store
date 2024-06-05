using Cosmetic_Store.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Cosmetic_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TempData["ClassName"] = "Grey Section";

            TempData.Keep();

            return View();
            
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Test()
        {


            return View("ProductView");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
