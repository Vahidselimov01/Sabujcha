using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sabujcha.Areas.SabujchaAdminPanel.ViewModels;
using Sabujcha.Models;
using Sabujcha.Utilities;
using System.Linq;
using System.Threading.Tasks;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{

    [Area("SabujchaAdminPanel")]
    [Authorize(Roles = "SuperAdmin")]
    public class UserEditsController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserEditsController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public IActionResult UserList()
        {
            var userList = userManager.Users
                .Select(user => new UserEditVM
                {
                    UserId = user.Id,
                    UserName = user.UserName,
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    IsBlock = user.IsBlock
                })
                .ToList();

            return View(userList);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> UserEdit(string userId, bool IsBlock)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user == null)
            {
                return View();

            }
            else
            {
                user.IsBlock = !user.IsBlock;
                var result = await userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("UserList"); // Başarılı güncelleme işlemi sonrası kullanıcı listesine yönlendirme
                }
                else
                {
                    return View("error");
                }

            }

        }

        public IActionResult UserDelete()
        {
            return View();
        }


        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> UserDelete(string userId)
        {
            var user = await userManager.FindByIdAsync(userId);

            if (user != null)
            {
                var result = await userManager.DeleteAsync(user);

                if (result.Succeeded)
                {
                    return RedirectToAction("UserDelete");
                }
                else
                {
                    // Hata durumunda işlemler
                }
            }
            else
            {
                // Kullanıcı bulunamadığında işlemler
            }

            // İşlem sonrası yönlendirme veya işlem sonuçlarına göre view döndürme
            return RedirectToAction("UserList");
        }


        public IActionResult UserCreate()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> UserCreate(UserCreateVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser
                {
                    UserName = model.Username,
                    Email = model.Email,
                    FirstName = model.FirstName,
                    LastName = model.LastName,

                };
                var result = await userManager.CreateAsync(user, model.Password);
                await userManager.AddToRoleAsync(user, Roles.Member.ToString());

                if (result.Succeeded)
                {
                    return RedirectToAction("Userlist");
                }

            }



            return View();
        }



    }
}
