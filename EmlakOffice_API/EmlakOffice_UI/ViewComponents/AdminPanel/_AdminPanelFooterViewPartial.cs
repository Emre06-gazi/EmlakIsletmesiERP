using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.AdminPanel
{
    public class _AdminPanelFooterViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}