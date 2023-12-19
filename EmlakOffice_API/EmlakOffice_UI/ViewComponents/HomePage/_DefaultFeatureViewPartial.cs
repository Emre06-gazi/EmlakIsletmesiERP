using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
    public class _DefaultFeatureViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
