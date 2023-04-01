using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class ExtraController : Controller
    {
        ExtraManager em = new ExtraManager(new EfExtraDal());
        public IActionResult ExtraList(Extra extra)
        {
            var values = em.TGetList(extra);
            return View(values);
        }
    }
}
