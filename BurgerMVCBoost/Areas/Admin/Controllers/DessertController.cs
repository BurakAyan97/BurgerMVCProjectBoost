using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DessertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
