using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultSubFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
