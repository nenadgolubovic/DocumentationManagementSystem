using DMS.Models;
using DMS.ViewModels;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using System.IO;
using DMS.Repositories;
using System;

namespace DocumentationManagementSystem.Controllers
{
    public class ComponentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ComponentController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

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
            var components = _context.Component.ToList(); 
            return View(components);
        }



        [HttpPost]

        public IActionResult AddComponent(ComponentViewModel model) 
        {
            if (!string.IsNullOrEmpty(model.Name))
            {
                var newComponent = new Component
                {
                    Name = model.Name,
                    Description = model.Description,
                    Type = model.Type
                };
                _context.Component.Add(newComponent);
                _context.SaveChanges();
            }
            return RedirectToAction("Component");
        }
    }
}
