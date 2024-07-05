using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
