using AutoMapper;
using SupermarketAPI.Models;
using SupermarketAPI.Models.Dtos;

namespace SupermarketAPI.Profiles
{
    public class SupermarketProfile : Profile
    {
        public SupermarketProfile()
        {
            CreateMap<CreateSupermarketDto, Supermarket>();
            CreateMap<Supermarket, ReadSupermaketDto>();
            CreateMap<UpdateSupermarketDto, Supermarket>();
        }
    }
}
