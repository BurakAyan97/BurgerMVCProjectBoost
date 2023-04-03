﻿using AutoMapper;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;

        public UserController(UserManager<AppUser> userManager, IPasswordHasher<AppUser> passwordHasher, IMapper mapper, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserVM user)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                _mapper.Map(user, appUser);

                if (user.Password != null)
                {
                    var result = await _userManager.CreateAsync(appUser, user.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Login");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "İşaretli yerler doldurulmak zorundadır.");
                }

            }
            return View(user);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            returnUrl = returnUrl is null ? "Home/Index" : returnUrl;
            return View(new UserVM() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserVM user)
        {
            if (!ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByNameAsync(user.UserName);

                if (appUser != null)
                {
                    await _signInManager.SignOutAsync();

                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(appUser, user.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Yanlış Kullanıcı Adı/Şifre.");
                }
            }
            return View(user);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
