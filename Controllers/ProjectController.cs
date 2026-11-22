using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class ProjectController : Controller
    {
        private readonly Context _context;

        public ProjectController(Context context)
        {
            _context = context;
        }

        
        public IActionResult Project()
        {
            var values = _context.Projects.ToList();
            return View(values);
        }
    }
}
