using Microsoft.AspNetCore.Mvc;

namespace KisiselSayfam.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string Email, string Password)
        {
            if (Email == "admin@gmail.com" && Password == "1234")
            {
                return RedirectToAction("Index", "Admin");
            }

            ViewBag.Error = "Email veya şifre hatalı.";
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
