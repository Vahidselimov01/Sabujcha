using Microsoft.AspNetCore.Mvc;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    public class DashboardController : Controller
    {
        [Area("SabujchaAdminpanel")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
