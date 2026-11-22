using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class ResumeController : Controller
    {
        private readonly Context _context;

        public ResumeController(Context context)
        {
            _context = context;
        }

        public IActionResult Resume()
        {
            var values = _context.Resumes.ToList();
            return View(values);
        }
    }
}
