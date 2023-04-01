using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
