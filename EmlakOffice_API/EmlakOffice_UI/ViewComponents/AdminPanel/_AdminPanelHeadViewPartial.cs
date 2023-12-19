using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.AdminPanel
{
    public class _AdminPanelHeadViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
