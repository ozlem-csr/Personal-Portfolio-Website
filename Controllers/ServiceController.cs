using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class ServiceController : Controller
    {
        private readonly Context _context;

        public ServiceController(Context context)
        {
            _context = context;
        }

        public IActionResult Service()
        {
            var values = _context.Services.ToList();
            return View(values);
        }
    }
}
