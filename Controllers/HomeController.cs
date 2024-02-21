using Microsoft.AspNetCore.Mvc;

namespace RaftEscalator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your Application Description Page.";

            return View();
        }
    }
}
