using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class HomeController : Controller
    {

        MenuManager menuManager = new MenuManager(new EfMenuDal());
        ExtraManager extraManager = new ExtraManager(new EfExtraDal());
        DessertManager dessertManager = new DessertManager(new EfDessertDal());
        SauceManager sauceManager = new SauceManager(new EfSauceDal());
        DrinkManager drinkManager = new DrinkManager(new EfDrinkDal());
        public IActionResult Index()
        {
            AllMenuVM vm = new AllMenuVM()
            {
                Extras = extraManager.TGetList(),
                Desserts = dessertManager.TGetList(),
                Sauces = sauceManager.TGetList(),
                Menus = menuManager.TGetList(),
                Drinks = drinkManager.TGetList(),
            };
            return View(vm);
        }
    }
}
