using DTO.DTOs;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Entities;
using Business.Interfaces;

namespace Business.Services
{

    public class CategoryService : GenericService<CategoryEntities,CategoryDTO>, ICategoryService
    {
        private readonly IGenericRepository<CategoryEntities> _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(IGenericRepository<CategoryEntities> categoryRepository, IMapper mapper)  :   base(categoryRepository, mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

    }
}
