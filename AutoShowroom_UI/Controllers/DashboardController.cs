using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
