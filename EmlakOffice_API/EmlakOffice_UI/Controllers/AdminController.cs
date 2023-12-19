using Microsoft.AspNetCore.Mvc;

namespace EmlakOffice_UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
