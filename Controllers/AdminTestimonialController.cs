using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly Context _context;

        public AdminTestimonialController(Context context)
        {
            _context = context;
        }

       
        public IActionResult TestimonialIndex()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        
        [HttpGet]
        public IActionResult AddAdminTestimonial()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAdminTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

        
        [HttpGet]
        public IActionResult GuncelleAdminTestimonial(int id)
        {
            var value = _context.Testimonials.Find(id);
            return View(value);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GuncelleAdminTestimonial(Testimonial testimonial)
        {
            _context.Testimonials.Update(testimonial);
            _context.SaveChanges();
            return RedirectToAction("TestimonialIndex");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminTestimonial(int id)
        {
            var testimonial = _context.Testimonials.Find(id);

            if (testimonial == null)
            {
                return RedirectToAction("TestimonialIndex");
            }

            _context.Testimonials.Remove(testimonial);
            _context.SaveChanges();

            return RedirectToAction("TestimonialIndex");
        }
    }
}
