using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class TestimonialController : Controller
    {
        private readonly Context _context;

        public TestimonialController(Context context)
        {
            _context = context;
        }

        public IActionResult Testimonial()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }
    }
}
