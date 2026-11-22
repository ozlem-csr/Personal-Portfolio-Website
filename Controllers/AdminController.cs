using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminController : Controller
    {
        private readonly Context _context;

        public AdminController(Context context)
        {
            _context = context;
        }

        // Dashboard
        public IActionResult Index()
        {
            return View();
        }

       
    }
}

