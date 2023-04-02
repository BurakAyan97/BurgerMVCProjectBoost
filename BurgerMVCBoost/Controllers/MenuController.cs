using AutoMapper;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class MenuController : Controller
    {
        MenuManager mm = new MenuManager(new EfMenuDal());
        ExtraManager em = new ExtraManager(new EfExtraDal());
        DessertManager dm = new DessertManager(new EfDessertDal());
        SauceManager sm = new SauceManager(new EfSauceDal());
        public IActionResult Menu()
        {
            AllMenuVM vm = new AllMenuVM()
            {
                Extras = em.TGetList(),
                Desserts = dm.TGetList(),
                Sauces = sm.TGetList(),
                Menus = mm.TGetList(),
            };
            return View(vm);


        }


    }
}
