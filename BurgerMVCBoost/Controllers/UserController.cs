using AutoMapper;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVC.ViewModel;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BurgerMVCBoost.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IPasswordHasher<AppUser> _passwordHasher;
        private readonly IMapper _mapper;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;

        public UserController(UserManager<AppUser> userManager, IPasswordHasher<AppUser> passwordHasher, IMapper mapper, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _passwordHasher = passwordHasher;
            _mapper = mapper;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser();
                _mapper.Map(register, appUser);

                IdentityResult result = await _userManager.CreateAsync(appUser, register.Password);
                await _userManager.AddToRoleAsync(appUser, "Customer");
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
            return View(register);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            returnUrl = returnUrl is null ? "Home/Index" : returnUrl;
            return View(new LoginVM() { ReturnUrl = returnUrl });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM user)
        {
            if (ModelState.IsValid)
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
        public async Task<IActionResult> ForgotPassword()
        {
            return View();
        }

        public IActionResult FacebookLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("FacebookResponse", "User", new { ReturnUrl = ReturnUrl });
            //Facebook'a yapılan Login talebi neticesinde kullanıcıyı yönlendirmesini istediğimiz url'i oluşturuyoruz.
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Facebook", redirectUrl);
            //Bağlantı kurulacak harici platformun hangisi olduğunu belirtiyor ve bağlantı özelliklerini elde ediyoruz.
            return new ChallengeResult("Facebook", properties);
            //ChallengeResult; kimlik doğrulamak için gerekli olan tüm özellikleri kapsayan AuthenticationProperties nesnesini alır ve ayarlar.
        }

        public async Task<IActionResult> FacebookResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            //Kullanıcıyla ilgili Facebook'tan gelen tüm bilgileri taşıyan nesnedir.
            //Bu nesnesnin 'LoginProvider' propertysinin değerine göz atarsanız eğer Facebook yazdığını göreceksiniz.
            //Eğer ki, Login işlemi Google yahut Twitter üzerinde gerçekleştirilmiş olsaydı provider olarak ilgili platformun adı yazacaktı.
            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                //Giriş yapıyoruz.
                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {
                    //Eğer ki akış bu bloğa girerse ilgili kullanıcı uygulamamıza kayıt olmadığından dolayı girişi başarısız demektir.
                    //O halde kayıt işlemini yapıp, ardından giriş yaptırmamız gerekmektedir.
                    AppUser user = new AppUser
                    {
                        Email =  loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };

                    //Facebook'tan gelen Claimleri uygun eşlendikleri propertylere atıyoruz.
                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    await _userManager.AddToRoleAsync(user, "Customer");
                    //Kullanıcı kaydını yapıyoruz.
                    if (createResult.Succeeded)
                    {
                        //Eğer kayıt başarılıysa ilgili kullanıcı bilgilerini AspNetUserLogins tablosuna kaydetmemiz gerekmektedir ki
                        //bir sonraki Facebook login talebinde Identity mimarisi ilgili kullanıcının Facebook'tan geldiğini anlayabilsin.
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);
                        //Kullanıcı bilgileri Facebook'tan gelen bilgileriyle AspNetUserLogins tablosunda eşleştirilmek suretiyle kaydedilmiştir.
                        if (addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    }

                }
            }
            return Redirect(ReturnUrl);
        }

      
        public IActionResult GoogleLogin(string ReturnUrl)
        {
            string redirectUrl = Url.Action("GoogleResponse", "User", new { ReturnUrl = ReturnUrl });
            //Facebook'a yapılan Login talebi neticesinde kullanıcıyı yönlendirmesini istediğimiz url'i oluşturuyoruz.
            AuthenticationProperties properties = _signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);

            //Bağlantı kurulacak harici platformun hangisi olduğunu belirtiyor ve bağlantı özelliklerini elde ediyoruz.
            return new ChallengeResult("Google", properties);
            //ChallengeResult; kimlik doğrulamak için gerekli olan tüm özellikleri kapsayan AuthenticationProperties nesnesini alır ve ayarlar.
        }

       
        public async Task<IActionResult> GoogleResponse(string ReturnUrl = "/")
        {
            ExternalLoginInfo loginInfo = await _signInManager.GetExternalLoginInfoAsync();
            //Kullanıcıyla ilgili Facebook'tan gelen tüm bilgileri taşıyan nesnedir.
            //Bu nesnesnin 'LoginProvider' propertysinin değerine göz atarsanız eğer Facebook yazdığını göreceksiniz.
            //Eğer ki, Login işlemi Google yahut Twitter üzerinde gerçekleştirilmiş olsaydı provider olarak ilgili platformun adı yazacaktı.
            if (loginInfo == null)
                return RedirectToAction("Login");
            else
            {
                Microsoft.AspNetCore.Identity.SignInResult loginResult = await _signInManager.ExternalLoginSignInAsync(loginInfo.LoginProvider, loginInfo.ProviderKey, true);
                //Giriş yapıyoruz.
                if (loginResult.Succeeded)
                    return Redirect(ReturnUrl);
                else
                {
                    //Eğer ki akış bu bloğa girerse ilgili kullanıcı uygulamamıza kayıt olmadığından dolayı girişi başarısız demektir.
                    //O halde kayıt işlemini yapıp, ardından giriş yaptırmamız gerekmektedir.
                    AppUser user = new AppUser
                    {
                        Email = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value,
                        UserName = loginInfo.Principal.FindFirst(ClaimTypes.Email).Value
                    };
                    //Facebook'tan gelen Claimleri uygun eşlendikleri propertylere atıyoruz.
                    IdentityResult createResult = await _userManager.CreateAsync(user);
                    await _userManager.AddToRoleAsync(user, "Customer");
                    //Kullanıcı kaydını yapıyoruz.
                    if (createResult.Succeeded)
                    {
                        //Eğer kayıt başarılıysa ilgili kullanıcı bilgilerini AspNetUserLogins tablosuna kaydetmemiz gerekmektedir ki
                        //bir sonraki Facebook login talebinde Identity mimarisi ilgili kullanıcının Facebook'tan geldiğini anlayabilsin.
                        IdentityResult addLoginResult = await _userManager.AddLoginAsync(user, loginInfo);
                        //Kullanıcı bilgileri Facebook'tan gelen bilgileriyle AspNetUserLogins tablosunda eşleştirilmek suretiyle kaydedilmiştir.
                        if (addLoginResult.Succeeded)
                        {
                            await _signInManager.SignInAsync(user, true);
                            return Redirect(ReturnUrl);
                        }
                    }

                }
            }
            return Redirect(ReturnUrl);
        }

    }
}