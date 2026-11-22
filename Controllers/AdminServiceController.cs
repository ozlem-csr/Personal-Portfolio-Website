using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminServiceController : Controller
    {
        private readonly Context _context;

        public AdminServiceController(Context context)
        {
            _context = context;
        }

        
        public IActionResult ServiceIndex()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

       
        [HttpGet]
        public IActionResult AddAdminService()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAdminService(Service service)
        {
            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }

       
        [HttpGet]
        public IActionResult GuncelleAdminService(int id)
        {
            var value = _context.Services.Find(id);
            return View(value);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GuncelleAdminService(Service service)
        {
            _context.Services.Update(service);
            _context.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminService(int id)
        {
            var service = _context.Services.Find(id);
            if (service == null)
            {
                return RedirectToAction("ServiceIndex");
            }

            _context.Services.Remove(service);
            _context.SaveChanges();
            return RedirectToAction("ServiceIndex");
        }
    }
}
