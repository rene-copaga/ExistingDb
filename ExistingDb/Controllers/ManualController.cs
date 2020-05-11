using ExistingDb.Models.Manual;
using Microsoft.AspNetCore.Mvc;

namespace ExistingDb.Controllers
{
    public class ManualController : Controller
    {
        private ManualContext context;

        public ManualController(ManualContext ctx) => context = ctx;

        public IActionResult Index() => View(context.Shoes);
    }
}
