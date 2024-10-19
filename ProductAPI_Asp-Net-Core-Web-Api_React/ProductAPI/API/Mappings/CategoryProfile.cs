using AutoMapper;
using DataAccess.Entities;
using DTO.DTOs;

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
