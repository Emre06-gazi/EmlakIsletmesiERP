using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.ViewComponents.Layout
{
    public class _HeaderViewPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
