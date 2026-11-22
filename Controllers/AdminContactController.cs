using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly Context _context;

        public AdminContactController(Context context)
        {
            _context = context;
        }

        public IActionResult AdminContact()
        {
            var values = _context.Contacts
                .OrderByDescending(x => x.Date)
                .ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult AddAdminContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAdminContact(Contact contact)
        {
            contact.Date = System.DateTime.Now;
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return RedirectToAction("AdminContact");
        }

        [HttpGet]
        public IActionResult GuncelleAdminContact(int id)
        {
            var value = _context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult GuncelleAdminContact(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();

            return RedirectToAction("AdminContact");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SilAdminContact(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction("AdminContact");
            }

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return RedirectToAction("AdminContact");
        }
    }
}
