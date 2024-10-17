using API.DTOs;
using AutoMapper;
using DataAccess.Entities;

namespace API.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            // Product entity ve ProductDto arasında iki yönlü mapping.
            CreateMap<ProductEntities, ProductDTO>().ReverseMap();
        }
    }
}
