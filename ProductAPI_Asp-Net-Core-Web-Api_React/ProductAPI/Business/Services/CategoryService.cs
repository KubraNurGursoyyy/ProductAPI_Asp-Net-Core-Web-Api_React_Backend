using DataAccess.Entities;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    internal class CategoryService : GenericService<CategoryEntities>
    {
        private readonly IGenericRepository<CategoryEntities> _categoryRepository;
        public CategoryService(IGenericRepository<CategoryEntities> categoryRepository) : base(categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
    }
}
