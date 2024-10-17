using Business.Interfaces;
using DataAccess.Entities;
using DataAccess.Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Business.Services
{
    internal class ProductService : GenericService<ProductEntities>, IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository) : base(productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<ProductEntities>> GetWhereAsync(int? desiredCategoryId = null, decimal? maxPrice = null)
        {
            // Başlangıçta tüm ürünleri döndürecek bir predicate oluşturuyoruz
            Expression<Func<ProductEntities, bool>> predicate = p => true;

            // Eğer kategori ID verilmişse, predicate'i güncelliyoruz
            if (desiredCategoryId.HasValue)
            {
                predicate = predicate.AndAlso(p => p.CategoryID == desiredCategoryId.Value);
            }

            // Eğer maksimum fiyat verilmişse, predicate'i güncelliyoruz
            if (maxPrice.HasValue)
            {
                predicate = predicate.AndAlso(p => p.Price <= maxPrice.Value);
            }

            // Filtrelenmiş ürünleri alıyoruz
            return await _productRepository.GetWhereAsync(predicate);


        }

    }
}
