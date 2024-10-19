using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTO.DTOs;

namespace Business.Interfaces
{
    public interface IProductService : IGenericService<ProductDTO>
    {
        Task<IEnumerable<ProductDTO>> GetWhereAsync(int? desiredCategoryId = null, decimal? maxPrice = null);
    }
}
