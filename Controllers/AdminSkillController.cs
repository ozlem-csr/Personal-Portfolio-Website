using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminSkillController : Controller
    {
        private readonly Context _context;

        public AdminSkillController(Context context)
        {
            _context = context;
        }

        
        public IActionResult SkillIndex()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        
        [HttpGet]
        public IActionResult AddAdminSkill()
        {
            return View();
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddAdminSkill(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillIndex");
        }

       
        [HttpGet]
        public IActionResult GuncelleAdminSkill(int id)
        {
            var value = _context.Skills.Find(id);
            return View(value);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GuncelleAdminSkill(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillIndex");
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminSkill(int id)
        {
            var skill = _context.Skills.Find(id);
            if (skill == null)
            {
                return RedirectToAction("SkillIndex");
            }

            _context.Skills.Remove(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillIndex");
        }
    }
}
