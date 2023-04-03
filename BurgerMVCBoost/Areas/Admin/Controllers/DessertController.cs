using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DessertController : Controller
    {
        DessertManager dessertManager = new DessertManager(new EfDessertDal());
        public IActionResult Index()
        {
            DessertViewModel model = new DessertViewModel()
            {
                Desserts = dessertManager.TGetList(),
                Dessert = new Dessert()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult DessertAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DessertAdd(Dessert dessert)
        {
            dessertManager.TAdd(dessert);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DessertUpdate(int id)
        {
            Dessert dessert = dessertManager.TGetByID(id);
            return PartialView(dessert);
        }

        [HttpPost]
        public IActionResult DessertUpdate(Dessert dessert)
        {
            dessert.UpdatedTime = DateTime.Now;
            dessertManager.TUpdate(dessert);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DessertDelete(int id)
        {
            var value = dessertManager.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult DessertDelete(Dessert dessert)
        {
            dessertManager.TDelete(dessert);
            return RedirectToAction("Index");
        }
    }
}
