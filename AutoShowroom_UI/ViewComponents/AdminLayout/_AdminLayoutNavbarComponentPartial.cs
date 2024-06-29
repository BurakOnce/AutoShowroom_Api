using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.AdminLayout
{
    public class _AdminLayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() {  return View(); }
    }
}
