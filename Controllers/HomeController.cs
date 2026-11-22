using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class HomeController : Controller
    {
        private readonly Context _context;

        public HomeController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Abouts = _context.Abouts.ToList();
            ViewBag.Services = _context.Services.ToList();
            ViewBag.Skills = _context.Skills.ToList();
            ViewBag.Testimonials = _context.Testimonials.ToList();
            ViewBag.Projects = _context.Projects.ToList();

            return View();
        }
    }
}

