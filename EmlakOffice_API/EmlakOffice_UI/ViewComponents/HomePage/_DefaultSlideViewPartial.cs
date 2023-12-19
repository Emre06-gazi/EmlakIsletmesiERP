using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
    public class _DefaultSlideViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}