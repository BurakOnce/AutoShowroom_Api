using Microsoft.AspNetCore.Mvc;

namespace AutoShowroom_UI.ViewComponents.HomePage
{
    public class _DefaultFeatureComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        { 
            return View();
        }
    }
}
