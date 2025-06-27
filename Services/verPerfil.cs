using Microsoft.AspNetCore.Mvc;

namespace mi_proyecto_aspnetcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}