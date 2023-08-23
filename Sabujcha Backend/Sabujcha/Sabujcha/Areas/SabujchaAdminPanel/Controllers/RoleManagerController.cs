using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sabujcha.Models;
using Sabujcha.Utilities;
using System.Linq;
using System.Threading.Tasks;

namespace Sabujcha.Areas.SabujchaAdminPanel.Controllers
{
    [Area("SabujchaAdminPanel")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class RoleManagerController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;

        public RoleManagerController(RoleManager<IdentityRole>roleManager)
        {
            this.roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return View(roles);
        }
        [HttpPost]
        
        public async Task<IActionResult> AddRole(string roleName)
        {
            if (roleName != null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName.Trim()));
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteRole(AppUser user)
        {
            var roleName=await roleManager.Roles.FirstOrDefaultAsync(a=>a.Id==user.Id);
            if (roleName != null)
            {
                await roleManager.DeleteAsync(roleName);
            }
            return RedirectToAction("Index");
        }
    }
}
