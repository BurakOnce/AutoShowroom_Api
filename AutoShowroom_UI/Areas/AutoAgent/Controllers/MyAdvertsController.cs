using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.Areas.AutoAgent.Controllers
{
    [Area("AutoAgent")]
    public class MyAdvertsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
