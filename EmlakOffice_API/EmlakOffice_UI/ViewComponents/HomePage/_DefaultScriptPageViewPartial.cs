using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.HomePage
{
    public class _DefaultScriptPageViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}