using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.Extensions;
using Sabujcha.Models;
using Sabujcha.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
  
    [Area("SabujchaAdminPanel")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class ProductsController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHost;

        public ProductsController(AppDbContext context, IWebHostEnvironment webHost)
        {
            this.context = context;
            this.webHost = webHost;
        }

        public async Task<IActionResult> Index()
        {
            var products = await context.Products.ToListAsync();
            return View(products);
        }

        public IActionResult Create()
        {
         return View();   

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<ActionResult> Create(Products products)
        {
            if (!ModelState.IsValid) return View();
            if (products.FormImage != null)
            {
               
                if (!products.FormImage.IsOkay(1))
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
                string fileName = products.FormImage.FileName;
                string path = Path.Combine(webHost.WebRootPath, "img", "product");
                products.ImageUlr = await products.FormImage.FileCreate(webHost.WebRootPath, @"assets\img\product");
                await context.Products.AddAsync(products);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }
        }
        public async Task<IActionResult> Details(int id)
        {
            Products product = await context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);

        }
        public async Task<IActionResult> Delete(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product != null)
            {
                string imagePath = "assets/img/product";
                string fullPath = Path.Combine(imagePath, product.ImageUlr);
                if (System.IO.File.Exists(fullPath))
                {
                    System.IO.File.Delete(fullPath);
                }

                context.Products.Remove(product);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }




        public IActionResult Edit(int id)
        {
            var product = context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Products product)
        {
            if (id != product.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var existingProduct = context.Products.Find(id);

                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.NewPrice = product.NewPrice;
                existingProduct.OldPrice = product.OldPrice;
                existingProduct.Rate = product.Rate;

                if (product.FormImage != null && product.FormImage.Length > 0)
                {
                    string uploadsFolder = Path.Combine("wwwroot", "assets","img","product");
                    string uniqueFileName = Guid.NewGuid().ToString() + "_" + product.FormImage.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await product.FormImage.CopyToAsync(stream);
                    }
                    existingProduct.ImageUlr = uniqueFileName;
                }

                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }
    }

}

