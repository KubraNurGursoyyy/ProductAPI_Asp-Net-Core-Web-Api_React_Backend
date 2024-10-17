using DataAccess.Context;
using DataAccess.Entities;
using DataAccess.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    internal class ProductRepository : GenericRepository<ProductEntities>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IEnumerable<ProductEntities>> GetWhereAsync(Expression<Func<ProductEntities, bool>> predicate)
        {
            return await _context.Products.Where(predicate).ToListAsync();
        }
    }
}
