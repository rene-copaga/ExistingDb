using Microsoft.AspNetCore.Mvc;

namespace ExistingDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
