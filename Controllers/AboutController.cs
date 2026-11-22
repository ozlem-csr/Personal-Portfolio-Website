using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AboutController : Controller
    {
        private readonly Context _context;

        public AboutController(Context context)
        {
            _context = context;
        }

        public IActionResult About()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }
    }
}
