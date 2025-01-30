using Microsoft.AspNetCore.Mvc;

namespace DocumentationManagementSystem.Areas.AssetManager.Controllers
{
    public class HomeController : Controller
    {
        [Area("AssetManager")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
