using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SauceController : Controller
    {
        SauceManager sauceManager = new SauceManager(new EfSauceDal());
        public IActionResult Index()
        {
            SauceViewModel model = new SauceViewModel()
            {
                Sauces = sauceManager.TGetList(),
                Sauce = new Sauce()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult SauceAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SauceAdd(Sauce sauce)
        {
            if (sauce.UpdatedTime is null)
                sauce.UpdatedTime = sauce.CreatedTime;

            sauceManager.TAdd(sauce);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SauceUpdate(int id)
        {
            Sauce sauce = sauceManager.TGetByID(id);
            return PartialView(sauce);
        }

        [HttpPost]
        public IActionResult SauceUpdate(Sauce sauce)
        {
            sauce.UpdatedTime = DateTime.Now;
            sauceManager.TUpdate(sauce);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult SauceDelete(int id)
        {
            var value = sauceManager.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult SauceDelete(Sauce sauce)
        {
            sauceManager.TDelete(sauce);
            return RedirectToAction("Index");
        }
    }
}
