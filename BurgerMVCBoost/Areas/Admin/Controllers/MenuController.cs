using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MenuController : Controller
    {
        MenuManager menuManager = new MenuManager(new EfMenuDal());
        public IActionResult Index()
        {
            MenuViewModel model = new MenuViewModel()
            {
                Menus = menuManager.TGetList(),
                Menu = new Menu()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult MenuAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MenuAdd(Menu menu)
        {
            menuManager.TAdd(menu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MenuUpdate(int id)
        {
            Menu menu = menuManager.TGetByID(id);
            return PartialView(menu);
        }

        [HttpPost]
        public IActionResult MenuUpdate(Menu menu)
        {
            menu.UpdatedTime = DateTime.Now;
            menuManager.TUpdate(menu);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult MenuDelete(int id)
        {
            var value = menuManager.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult MenuDelete(Menu menu)
        {
            menuManager.TDelete(menu);
            return RedirectToAction("Index");
        }
    }
}
