using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.Layout
{
    public class _NavbarViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
