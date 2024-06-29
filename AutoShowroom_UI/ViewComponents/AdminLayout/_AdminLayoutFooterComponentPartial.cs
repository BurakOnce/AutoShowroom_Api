using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutFooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }
    }
}
