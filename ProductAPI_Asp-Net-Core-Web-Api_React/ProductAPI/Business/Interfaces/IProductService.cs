using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    internal interface IProductService : IGenericService<ProductEntities>
    {
        Task<IEnumerable<ProductEntities>> GetWhereAsync(int? desiredCategoryId = null, decimal? maxPrice = null);
    }
}
