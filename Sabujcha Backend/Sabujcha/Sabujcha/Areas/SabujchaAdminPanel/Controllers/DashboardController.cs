using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    public class DashboardController : Controller
    {
        [Area("SabujchaAdminpanel")]
        [Authorize(Roles = "SuperAdmin")]
        public IActionResult Index()
        {
            return View();
        }

    }
}
