using DTO.DTOs;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess.Entities;

namespace Business.Services
{
    internal class CategoryService : GenericService<CategoryEntities,CategoryDTO>
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
