using AutoMapper;
using BurgerMVC.BusinessLayer.Concrete;
using BurgerMVC.DataLayer.EntityFramework;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCBoost.Controllers
{
    public class MenuController : Controller
    {
        private readonly IMapper _mapper;

        public MenuController(IMapper mapper)
        {
            _mapper = mapper;
        }

        MenuManager mm = new MenuManager(new EfMenuDal());
        public IActionResult MenuList()
        {
            AllMenuVM vm = new AllMenuVM();
            _mapper.Map()
            
            
            return View(vm);
        }


    }
}
