using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class SkillController : Controller
    {
        private readonly Context _context;

        public SkillController(Context context)
        {
            _context = context;
        }

        public IActionResult Skill()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }
    }
}
