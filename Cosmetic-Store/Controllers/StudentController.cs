using Microsoft.AspNetCore.Mvc;

namespace FirstWebApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
