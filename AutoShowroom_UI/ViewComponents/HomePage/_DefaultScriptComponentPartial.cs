using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
