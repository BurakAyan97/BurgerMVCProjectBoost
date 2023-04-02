using AutoMapper;
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

        public UserController(UserManager<AppUser> userManager, IPasswordHasher<AppUser> passwordHasher, IMapper mapper)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
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
                var result = await _userManager.CreateAsync(appUser);
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
            return View();
        }
    }
}
