using AutoMapper;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;

namespace BurgerMVCBoost.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Dessert, DessertVM>().ReverseMap();
            CreateMap<Extra, ExtraVM>().ReverseMap();
            CreateMap<Menu, MenuVM>().ReverseMap();
            CreateMap<Sauce, SauceVM>().ReverseMap();
        }
    }
}
