using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.ViewModels;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext context;

        public AboutUsController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task < IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM { 
                AboutUsAreas=await context.AboutUsAreas.FirstOrDefaultAsync()

            };

            return View(aboutVM);
        }
    }
}
