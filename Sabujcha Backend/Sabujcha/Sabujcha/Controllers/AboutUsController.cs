using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.Models;
using Sabujcha.ViewModels;
using System.IO;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHost;

        public AboutUsController(AppDbContext context, IWebHostEnvironment webHost)
        {
            this.context = context;
            this.webHost = webHost;
        }
        public async Task < IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM { 
                AboutUsAreas=await context.AboutUsAreas.ToListAsync()

            };

            return View(aboutVM);
        }
       


    }
}
