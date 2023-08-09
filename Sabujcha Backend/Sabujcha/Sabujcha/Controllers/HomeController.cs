using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Sabujcha.DAL;
using Sabujcha.Models;
using Sabujcha.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;

        public HomeController(AppDbContext context)
        {
            this.context = context;
        }
       

        public async Task< IActionResult> Index()
        {
            HomeViewModels homeViewModels = new HomeViewModels {
                products = await context.Products.OrderBy(p => p.Id).ToListAsync(),
                productsIcons=await context.ProductsIcons.OrderBy(pi => pi.Id).ToListAsync(), 
                

            };


          
                 ;   
            return View(homeViewModels);
        }

       
    }
}
