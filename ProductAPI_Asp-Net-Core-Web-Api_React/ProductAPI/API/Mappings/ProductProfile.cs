using AutoMapper;
using DataAccess.Entities;
using DTO.DTOs;

namespace API.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductEntities, ProductDTO>().ReverseMap();
        }
    }
}
