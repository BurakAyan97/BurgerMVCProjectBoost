using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DrinkController : Controller
    {
        DrinkManager drinkManager = new DrinkManager(new EfDrinkDal());
        public IActionResult Index()
        {
            DrinkViewModel model = new DrinkViewModel()
            {
                Drinks = drinkManager.TGetList(),
                Drink = new Drink()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult DrinkAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DrinkAdd(Drink drink)
        {
            if (drink.UpdatedTime is null)
                drink.UpdatedTime = drink.CreatedTime;

            drinkManager.TAdd(drink);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DrinkUpdate(int id)
        {
            Drink drink = drinkManager.TGetByID(id);
            return PartialView(drink);
        }

        [HttpPost]
        public IActionResult DrinkUpdate(Drink drink)
        {
            drink.UpdatedTime = DateTime.Now;
            drinkManager.TUpdate(drink);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DrinkDelete(int id)
        {
            var value = drinkManager.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult DrinkDelete(Drink drink)
        {
            drinkManager.TDelete(drink);
            return RedirectToAction("Index");
        }
    }
}
