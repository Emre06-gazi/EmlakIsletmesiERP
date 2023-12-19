using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
    public class _DefaultEmlakViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
