using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
