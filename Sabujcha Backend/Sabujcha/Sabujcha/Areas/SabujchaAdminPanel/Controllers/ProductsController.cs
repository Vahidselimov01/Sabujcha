using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    [Area("SabujchaAdminPanel")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext context;

        public ProductsController(AppDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var products = await context.Products.ToListAsync();
            return View(products);
        }
        [HttpGet]
        public async Task< IActionResult> Details(int id)
        {
            Products product =  await  context.Products.FirstOrDefaultAsync(p => p.Id == id);
            //if (product == null)
            //{
            //    return NotFound();
            //}
            return View(product);

        }

    }


}
