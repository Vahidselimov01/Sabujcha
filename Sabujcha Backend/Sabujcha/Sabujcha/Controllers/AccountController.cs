using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sabujcha.Models;
using Sabujcha.ViewModels;
using System;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (!ModelState.IsValid) return View(register);
            AppUser user = new AppUser
            {

                FirstName = register.FirstName,
                LastName = register.LastName,
                Email = register.Email,
                UserName = register.UserName,
                TermsConfirmed = register.TermsConfirmed
                
            };

            if (!register.TermsConfirmed)
            {
                ModelState.AddModelError("", "Qaydalari diqqetli oxuyub qebul edin ");
                return View();
            }
            else
            {
                IdentityResult result = await userManager.CreateAsync(user, register.Password);

                if (!result.Succeeded)
                {
                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                   
                    return View();
                }

                await signInManager.SignInAsync(user, false);

            }
           
         
            return RedirectToAction("Index", "Home");


        }

        public IActionResult Login()
        {

            return View();

        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {

            if (!ModelState.IsValid) return View(login);
            AppUser user = await userManager.FindByNameAsync(login.UserName);
           
            if (user == null)

            {
               return View(login);
            }
      
            
            if (login.RememberMe)
            {
                Microsoft.AspNetCore.Identity.SignInResult signInResult = await signInManager.PasswordSignInAsync(user, login.Password, true, true);
                if (!signInResult.Succeeded)
                {
                    if (signInResult.IsLockedOut)
                    {
                        ModelState.AddModelError("", "You Have a dissmiss count 3");
                    }

                }
            }
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult signInResult = await signInManager.PasswordSignInAsync(user, login.Password, false, true);
                if (!signInResult.Succeeded)
                {
                    if (signInResult.IsLockedOut)
                    {
                        ModelState.AddModelError("","You Have a dissmiss count 3");
                    }

                }

            }
          return  RedirectToAction("Index", "Home");
    
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
