using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Sokokapu_Stock_Management.Models;
using Sokokapu_Stock_Management.ViewModels;

namespace Sokokapu_Stock_Management.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVm loginVm)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(loginVm.Username, loginVm.Password, loginVm.Rememberme, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Product");
                }

                ModelState.AddModelError("", "Invalid Login Attempt!!!");
                return View(loginVm);
            }

            return View(loginVm);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVm register)
        {
            if (ModelState.IsValid)
            {
                var user = new User()
                {
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    Email = register.Email,
                    PhoneNumber = register.Phone,
                    UserName = register.Email,
                    OfficeNo = register.OfficeId,

                };

                var result = await userManager.CreateAsync(user, register.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Product");
                }

                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }
            return View(register);
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Product");
        }

    }
}