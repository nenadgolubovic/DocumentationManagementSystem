using Microsoft.AspNetCore.Mvc;

namespace DocumentationManagementSystem.Areas.AssetManager.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
