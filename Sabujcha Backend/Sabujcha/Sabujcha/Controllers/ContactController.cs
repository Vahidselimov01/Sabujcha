using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.DAL;
using Sabujcha.Models;
using Sabujcha.ViewModels;
using System;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{

    public class ContactController : Controller
    {
        private readonly AppDbContext context;

        public ContactController(AppDbContext context)
        {
            this.context = context;
        }
    
        public async Task<IActionResult>Index(bool isSuccess)
        {
            ViewBag.IsSuccess = isSuccess;

            HomeViewModels homeViewModels = new HomeViewModels
            {
             Contacts = await context.ContactUs.ToListAsync(),
            };
			
			return View(homeViewModels);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(ContactUs contact)
        {
            if (!ModelState.IsValid)
            {

                return View("Error");

            }

            if (contact==null)
            {
                ModelState.AddModelError("", "Datalari doldurun");

            }

            contact.Date = DateTime.Parse(DateTime.Now.ToShortDateString());

            await context.ContactUs.AddAsync(contact);
			await context.SaveChangesAsync();
		
			return RedirectToAction("Index", "Home", new { IsSuccess = true });

		}

    }
}
