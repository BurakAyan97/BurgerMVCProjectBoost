using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ExtraController : Controller
    {
        ExtraManager extraManager = new ExtraManager(new EfExtraDal());
        public IActionResult Index()
        {
            ExtraViewModel model = new ExtraViewModel()
            {
                Extras = extraManager.TGetList(),
                Extra = new Extra()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult ExtraAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExtraAdd(Extra extra)
        {
            if (extra.UpdatedTime is null)
                extra.UpdatedTime = extra.CreatedTime;

            extraManager.TAdd(extra);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ExtraUpdate(int id)
        {
            Extra extra = extraManager.TGetByID(id);
            return PartialView(extra);
        }

        [HttpPost]
        public IActionResult ExtraUpdate(Extra extra)
        {
            extra.UpdatedTime = DateTime.Now;
            extraManager.TUpdate(extra);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ExtraDelete(int id)
        {
            var value = extraManager.TGetByID(id);
            return PartialView(value);
        }

        [HttpPost]
        public IActionResult ExtraDelete(Extra extra)
        {
            extraManager.TDelete(extra);
            return RedirectToAction("Index");
        }
    }
}
