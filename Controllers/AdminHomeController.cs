using Microsoft.AspNetCore.Mvc;

namespace KisiselSayfam.Controllers
{
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
