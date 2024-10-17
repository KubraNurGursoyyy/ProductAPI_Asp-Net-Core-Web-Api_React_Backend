using API.DTOs;
using AutoMapper;
using DataAccess.Entities;

namespace API.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<CategoryEntities, CategoryDTO>().ReverseMap();
        }
    }
}
