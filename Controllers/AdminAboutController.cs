using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KisiselSayfam.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly Context _context;

        public AdminAboutController(Context context)
        {
            _context = context;
        }

        public IActionResult AboutIndex()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdminAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdminAbout(About about, IFormFile ResimDosyasi)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }

        [HttpGet]
        public IActionResult GuncelleAdminAbout(int id)
        {
            var value = _context.Abouts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult GuncelleAdminAbout(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("AboutIndex");
        }
        
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminAbout(int id)
        {
            var about = _context.Abouts.Find(id);

            if (about == null)
            {
                return RedirectToAction("AboutIndex");
            }

            _context.Abouts.Remove(about);
            _context.SaveChanges();

            return RedirectToAction("AboutIndex");
        }
    }
}
