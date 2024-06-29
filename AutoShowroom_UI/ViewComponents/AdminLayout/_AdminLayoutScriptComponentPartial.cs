using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutScriptComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() { return View(); }

    }
}
