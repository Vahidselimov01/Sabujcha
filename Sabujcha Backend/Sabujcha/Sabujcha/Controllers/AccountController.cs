using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sabujcha.Models;
using Sabujcha.ViewModels;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AccountController(UserManager<AppUser>userManager)
        {
            this.userManager = userManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register )
        {
            if(!ModelState.IsValid)return View(register);
            AppUser user = new AppUser { 
            
            FirstName = register.FirstName,
            LastName = register.LastName,
            Email = register.Email,
             UserName = register.UserName,
            };
         IdentityResult result=await userManager.CreateAsync(user,register.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            return RedirectToAction("Index","Home");
           

        }

        public IActionResult Login()
        {

           return RedirectToAction("Index","Home");

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult>Login(LoginVM login)
        {

            if (!ModelState.IsValid) return View(login);
            AppUser user = new AppUser
            {
                 UserName= login.UserName,
                 Email = login.Email,

            };
            
           RedirectToAction("Index","Home");
            return View(user);

        }

    }
}
