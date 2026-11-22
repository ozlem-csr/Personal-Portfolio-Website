using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminResumeController : Controller
    {
        private readonly Context _context;

        public AdminResumeController(Context context)
        {
            _context = context;
        }

        public IActionResult ResumeIndex()
        {
            var values = _context.Resumes.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdminResume()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAdminResume(Resume resume)
        {
            _context.Resumes.Add(resume);
            _context.SaveChanges();
            return RedirectToAction("ResumeIndex");
        }

        [HttpGet]
        public IActionResult GuncelleAdminResume(int id)
        {
            var value = _context.Resumes.Find(id);
            return View(value);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GuncelleAdminResume(Resume resume)
        {
            _context.Resumes.Update(resume);
            _context.SaveChanges();
            return RedirectToAction("ResumeIndex");
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminResume(int id)
        {
            var resume = _context.Resumes.Find(id);

            if (resume == null)
            {
                return RedirectToAction("ResumeIndex");
            }

            _context.Resumes.Remove(resume);
            _context.SaveChanges();
            return RedirectToAction("ResumeIndex");
        }
    }
}

