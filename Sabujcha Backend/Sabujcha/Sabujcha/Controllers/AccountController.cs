using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sabujcha.Models;
using Sabujcha.Utilities;
using Sabujcha.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Sabujcha.Controllers
{
	public class AccountController : Controller
	{
		private readonly UserManager<AppUser> userManager;
		private readonly SignInManager<AppUser> signInManager;
		private readonly RoleManager<IdentityRole> roleManager;

		public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
			this.roleManager = roleManager;
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
				string token = await userManager.GenerateEmailConfirmationTokenAsync(user);
				string link = Url.Action(nameof(VerifyEmail), "Account", new { email = user.Email, token }, Request.Scheme, Request.Host.ToString());
				MailMessage message = new MailMessage();
				message.From = new MailAddress("vahidslimov01@gmail.com");
				message.To.Add(new MailAddress(user.Email, "Sabujcha Company"));
				message.Subject = "Verify Email";
				string body = string.Empty;
				using (StreamReader reader = new StreamReader("wwwroot/assets/Template/verifyemail.html"))
				{
					body = reader.ReadToEnd();
				}

				string about = $"Hi <strong>{user.FirstName + " " + user.LastName}</strong> In order to start using your  account, you need to confirm your email address.";
				body = body.Replace("{{link}}", link);
				message.Body = body.Replace("{{About}}", about);
				message.IsBodyHtml = true;
				SmtpClient smtp = new SmtpClient();
				smtp.Host = "smtp.gmail.com";
				smtp.Port = 587;
				smtp.EnableSsl = true;
				smtp.Credentials = new NetworkCredential("vahidslimov01@gmail.com", "vmyundxtbtshjdvg");
				smtp.Send(message);
				TempData["Verify"] = true;
				await userManager.AddToRoleAsync(user, Roles.Member.ToString());
				await signInManager.SignInAsync(user, false);

			}
			return RedirectToAction("Index", "Home");


		}
		public async Task<IActionResult> VerifyEmail(string email, string token)
		{
			AppUser user = await userManager.FindByEmailAsync(email);
			if (user == null)
			{
				return BadRequest();
			}
			await userManager.ConfirmEmailAsync(user, token);
			await signInManager.SignInAsync(user, true);
			TempData["Verified"] = true;

			return RedirectToAction("Home", "Index");


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
				return View();
			}
			IList<string> roles = await userManager.GetRolesAsync(user);
			string role = roles.FirstOrDefault(r => r.ToLower().Trim() == Roles.Member.ToString().ToLower().Trim());
			

		


            if (roles == null)
			{
				return View("Error");
			}

			else
			if (role == Roles.Member.ToString())
			{
				{
					if (login.RememberMe)
					{
						Microsoft.AspNetCore.Identity.SignInResult signInResult = await signInManager.PasswordSignInAsync(user, login.Password, true, true);

						if (!signInResult.Succeeded)
						{
							ModelState.AddModelError("", "Username ve yaxud parol sehvdi");
							
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
                            ModelState.AddModelError("", "Username ve yaxud parol sehvdi");
                            if (signInResult.IsLockedOut)
							{
								ModelState.AddModelError("", "You Have a dissmiss count 3");
							}

						}

					}
				}
			}
			else
			{
				return View("error");
			}
			
			return RedirectToAction("Index", "Home");

		}


		public async Task<IActionResult> Logout()
		{
			await signInManager.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}
		[Authorize(Roles = "Member")]
		public IActionResult MyAccount()
		{
			return View();
		}

		public async Task<IActionResult> Account(AccountVM account)
		{
			if (!ModelState.IsValid)
			{

				var ModelState = signInManager.SignOutAsync();

				return View(ModelState);

			}
			/// 1ci usul
			/// ///
			//AppUser user = await userManager.FindByNameAsync(User.Identity.Name);

			///2ci usul ///
			///
			AppUser user = await userManager.GetUserAsync(User);
			if (user == null)
			{

				return View("Error");
			}
			else
			{
				account.UserName = user.UserName;
				account.Email = user.Email;
				account.FirsName = user.FirstName;
				account.LastName = user.LastName;

				return View(account);

			}


		}

		public async Task<IActionResult> CreateRoles()
		{
			if (!ModelState.IsValid) return View();


			await roleManager.CreateAsync(new IdentityRole { Name = Roles.Member.ToString() });
			await roleManager.CreateAsync(new IdentityRole { Name = Roles.Admin.ToString() });
			await roleManager.CreateAsync(new IdentityRole { Name = Roles.SuperAdmin.ToString() });


			return RedirectToAction("Index", "Home");



		}


		[Authorize(Roles ="Member")]
		public async Task<IActionResult> Settings()
		{
			if (!ModelState.IsValid) { return View(); }
			AppUser user= await userManager.FindByNameAsync(User.Identity.Name);
			if (user==null)
			{
				return View();
			}
            else
            {
				SettingsVM settings = new SettingsVM
				{
					FirstName=user.FirstName,
					UserName=user.UserName,
					Email=user.Email,
					LastName=user.LastName,
				


				};

                return View(settings);

            }	
		}




		[HttpPost]
		[AutoValidateAntiforgeryToken]
		public async Task<IActionResult>Settings(SettingsVM vM)
		{

            AppUser Existeduser = await userManager.FindByNameAsync(User.Identity.Name);
            SettingsVM settingsVM = new SettingsVM
            {
                UserName = Existeduser.UserName,
                LastName = Existeduser.LastName,
                Email = Existeduser.Email,

            };
            if (!ModelState.IsValid) return View();


            bool result = vM.Password == null && vM.ConfirmPassword == null && vM.CurrentPassword != null;
            if (vM.Email == null || vM.Email != Existeduser.Email)
            {
                ModelState.AddModelError("", "You can not change your email");
                return View(settingsVM);
            }
            if (result)
            {
                Existeduser.UserName = vM.UserName;
                Existeduser.LastName = vM.LastName;
                Existeduser.Email = vM.Email;
                Existeduser.PasswordHash = vM.Password;

                await userManager.UpdateAsync(Existeduser);

            }
            else
            {
                Existeduser.UserName = vM.UserName;
                Existeduser.LastName = vM.LastName;
                Existeduser.Email = vM.Email;
                if (vM.CurrentPassword == vM.Password)
                {
                    ModelState.AddModelError("", "You can not change password with the same password");
                    return View();
                }
                IdentityResult ResultSettings = await userManager.ChangePasswordAsync(Existeduser, vM.CurrentPassword, vM.Password);
                if (!ResultSettings.Succeeded)
                {
                    foreach (IdentityError error in ResultSettings.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(settingsVM);
                }

            }
			return RedirectToAction("MyAccount","Account");


        }





//Bu bir defe Ise salanir ve SuperAdmin Yaradilir ...




		public async Task<IActionResult> CreateAdmin()
		{
			AppUser user = new AppUser
			{
				FirstName = "Super",
				LastName = "Admin",
				UserName = "SuperAdmin",
				TermsConfirmed = true,
				EmailConfirmed = true,



			};
			
				await userManager.CreateAsync(user, "Vahid1-1");
				await userManager.AddToRoleAsync(user, Roles.SuperAdmin.ToString());
	
			return Content("Super Admin Was Successfully Created");


		

		}


	}
}





