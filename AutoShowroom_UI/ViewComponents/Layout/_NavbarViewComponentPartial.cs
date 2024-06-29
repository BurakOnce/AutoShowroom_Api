using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.Layout
{
    public class _NavbarViewComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
