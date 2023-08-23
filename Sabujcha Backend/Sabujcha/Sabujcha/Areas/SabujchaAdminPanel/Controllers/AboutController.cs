using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.Models;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Sabujcha.ViewModels;
using Sabujcha.Extensions;
using Sabujcha.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    [Area("SabujchaAdminPanel")]
    
    public class AboutController : Controller
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment webHost;

        public AboutController(AppDbContext context, IWebHostEnvironment webHost)
        {
            this.context = context;
            this.webHost = webHost;
        }
        public async Task<IActionResult> Index()
        {
            AboutVM aboutVM = new AboutVM
            {

                AboutUsAreas = await context.AboutUsAreas.ToListAsync(),
            };

            return View(aboutVM);
        }
        public IActionResult Create()
        {
            return View();
        }

        #region MyRegion

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(AboutUsArea item, IFormFile FormFile, IFormFile FormFile2)
        {
            if (ModelState.IsValid)
            {
                if (FormFile != null)
                {
                    string imagePath1 = Path.Combine(webHost.WebRootPath, "assets", "img", "banner", FormFile.FileName);
                    using (var stream = new FileStream(imagePath1, FileMode.Create))
                    {
                        await FormFile.CopyToAsync(stream);
                    }
                    item.ImageUrl = "/assets/img/banner/" + FormFile.FileName;
                }

                if (FormFile2 != null)
                {
                    string imagePath2 = Path.Combine(webHost.WebRootPath, "assets", "img", "icon-img", FormFile2.FileName);
                    using (var stream = new FileStream(imagePath2, FileMode.Create))
                    {
                        await FormFile2.CopyToAsync(stream);
                    }
                    item.Signature = "/assets/img/icon-img/" + FormFile2.FileName;
                }

                context.AboutUsAreas.Add(item);
                context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        public IActionResult Delete(int id)
        {
            var item = context.AboutUsAreas.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var item = context.AboutUsAreas.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            if (!string.IsNullOrEmpty(item.ImageUrl))
            {
                string imagePath1 = Path.Combine(webHost.WebRootPath, item.ImageUrl.TrimStart('/'));
                if (System.IO.File.Exists(imagePath1))
                {
                    System.IO.File.Delete(imagePath1);
                }
            }

            if (!string.IsNullOrEmpty(item.Signature))
            {
                string imagePath2 = Path.Combine(webHost.WebRootPath, item.Signature.TrimStart('/'));
                if (System.IO.File.Exists(imagePath2))
                {
                    System.IO.File.Delete(imagePath2);
                }
            }

            context.AboutUsAreas.Remove(item);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }


        public async Task< IActionResult> Detail(int id)
        {
            AboutUsArea about=await context.AboutUsAreas.FirstOrDefaultAsync(a=>a.Id==id);
            if (about == null)
            {
                return NotFound();
            }

            return View(about);
        }








        public IActionResult Edit(int id)
        {
            var item = context.AboutUsAreas.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, AboutUsArea item, IFormFile imageFile1, IFormFile imageFile2)
        {
            if (id != item.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                if (imageFile1 != null)
                {
                    var imagePath1 = Path.Combine(webHost.WebRootPath, "assets", "img", "banner", imageFile1.FileName);
                    using (var stream = new FileStream(imagePath1, FileMode.Create))
                    {
                        await imageFile1.CopyToAsync(stream);
                    }
                    item.ImageUrl = "/assets/img/banner/" + imageFile1.FileName;
                }

                if (imageFile2 != null)
                {
                    var imagePath2 = Path.Combine(webHost.WebRootPath, "assets", "img", "icon-img", imageFile2.FileName);
                    using (var stream = new FileStream(imagePath2, FileMode.Create))
                    {
                        await imageFile2.CopyToAsync(stream);
                    }
                    item.Signature = "/assets/img/icon-img/" + imageFile2.FileName;
                }

                context.Update(item);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(item);
        }


    }


    #endregion


}

