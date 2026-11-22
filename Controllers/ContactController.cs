using KisiselSayfam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace KisiselSayfam.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context _context;

        public ContactController(Context context)
        {
            _context = context;
        }

        
        public IActionResult Contact()
        {
            var values = _context.Contacts
                                 .OrderByDescending(x => x.Date)
                                 .ToList();

            return View(values); 
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact(Contact contact)
        {
            contact.Date = System.DateTime.Now;
            _context.Contacts.Add(contact);
            _context.SaveChanges();

            return RedirectToAction("Contact");
        }
    }
}
