using DMS.Models;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace DocumentationManagementSystem.Controllers
{
    public class ComponentController : Controller
    {
        private static List<Component> component = new List<Component>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Component()
        {
            return View(component);
        }


        [HttpPost]

        public IActionResult AddComponent(int id, string desctiption, string name, string type) 
        {
            if (!string.IsNullOrEmpty(name))
            {
                var newComponent = new Component { Id = component.Count + 1, Name = name, Description = desctiption, Type = type };
                component.Add(newComponent);
            }
            return RedirectToAction("Component");
        }
    }
}
