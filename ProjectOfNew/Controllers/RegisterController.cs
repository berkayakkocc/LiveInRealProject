using Entities.Concrete;
using LiveInRealProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LiveInRealProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task < IActionResult> Index(UserRegisterViewModel userRegisterViewModel)
        {
            AppUser appUser = new AppUser
            {
                Name = userRegisterViewModel.Name,
                Surname = userRegisterViewModel.LastName,
                UserName = userRegisterViewModel.Username,
                
                Email = userRegisterViewModel.Mail,

            };
            if (userRegisterViewModel.Password == userRegisterViewModel.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, userRegisterViewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
                
            return View(userRegisterViewModel);
        }
    }
}
