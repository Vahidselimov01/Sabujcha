using Microsoft.AspNetCore.Mvc;
using Sabujcha.DAL;
using Sabujcha.Models;
using System.Collections.Generic;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    [Area("SabujchaAdminpanel")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext context;

        public ProductsController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            List<Products>products = new List<Products>();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create() {
            Products products = new Products();
            return View(products);
        }

    }
}
