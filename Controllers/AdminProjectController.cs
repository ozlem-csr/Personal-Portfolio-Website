using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminProjectController : Controller
    {
        private readonly Context _context;

        public AdminProjectController(Context context)
        {
            _context = context;
        }

        public IActionResult ProjectIndex()
        {
            var values = _context.Projects.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdminProject()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAdminProject(Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return RedirectToAction("ProjectIndex");
        }

        [HttpGet]
        public IActionResult GuncelleAdminProject(int id)
        {
            var value = _context.Projects.Find(id);
            return View(value);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GuncelleAdminProject(Project project)
        {
            _context.Projects.Update(project);
            _context.SaveChanges();
            return RedirectToAction("ProjectIndex");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminProject(int id)
        {
            var project = _context.Projects.Find(id);

            if (project == null)
            {
                return RedirectToAction("ProjectIndex");
            }

            _context.Projects.Remove(project);
            _context.SaveChanges();

            return RedirectToAction("ProjectIndex");
        }
    }
}

