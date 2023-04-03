using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        public IActionResult OrderList()
        {
            return View();
        }
    }
}
