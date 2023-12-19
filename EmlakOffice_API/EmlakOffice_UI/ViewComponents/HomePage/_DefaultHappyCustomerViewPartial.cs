using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
    public class _DefaultHappyCustomerViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}