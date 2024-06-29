using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
