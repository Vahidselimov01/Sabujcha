using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sabujcha.Models;
using Sabujcha.Utilities;
using Sabujcha.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    [Area("SabujchaAdminPanel")]
    public class AccountAdminController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountAdminController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Login(LoginVM login)
        {

            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(login.UserName);
                if (user != null && await userManager.CheckPasswordAsync(user, login.Password))
                {
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles.Contains("Admin") || roles.Contains("SuperAdmin"))
                    {
                        await signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Dashboard"); // Başarılı login sonrası admin paneline yönlendir
                    }
                    else
                    {
                        ModelState.AddModelError("", "You don't have permission to access the admin panel.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                }
            }
            return View(login);
        }








    }



}
