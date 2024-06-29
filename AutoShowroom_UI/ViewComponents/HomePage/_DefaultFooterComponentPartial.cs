using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
