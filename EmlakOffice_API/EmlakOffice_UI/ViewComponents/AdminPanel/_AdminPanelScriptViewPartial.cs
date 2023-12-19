using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.AdminPanel
{
    public class _AdminPanelScriptViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}