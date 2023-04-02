using AutoMapper;
using BurgerMVC.EntityLayer.Concrete;
using BurgerMVCBoost.ViewModel;

namespace BurgerMVCBoost.AutoMapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AppUser, UserVM>().ReverseMap();
        }
    }
}
