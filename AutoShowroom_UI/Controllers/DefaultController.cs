using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
