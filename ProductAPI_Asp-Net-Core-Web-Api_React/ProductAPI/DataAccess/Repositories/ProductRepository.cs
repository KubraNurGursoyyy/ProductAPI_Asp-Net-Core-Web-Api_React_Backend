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
            //burada eğer istenirse ürünleri kategoriye, fiyata ve hem kategori hem fiyata göre listeleyebilmeli
            //örnek kullanım
            //var productsByCategory = await _productRepository.GetWhereAsync(p => p.CategoryId == desiredCategoryId);
            //var productsByPrice = await _productRepository.GetWhereAsync(p => p.Price <= maxPrice);
            //var productsByCategoryAndPrice = await _productRepository.GetWhereAsync(p => p.CategoryId == desiredCategoryId && p.Price <= maxPrice);
            /*
             * service kısmına yazılacak kod
             Expression<Func<ProductEntities, bool>> predicate = p => true;
                if (desiredCategoryId != null)
                {
                    predicate = predicate.AndAlso(p => p.CategoryId == desiredCategoryId);
                }

                if (maxPrice != null)
                {
                    predicate = predicate.AndAlso(p => p.Price <= maxPrice);
                }

                var filteredProducts = await _productRepository.GetWhereAsync(predicate);

             */
            return await _context.Products.Where(predicate).ToListAsync();
        }
    }
}
