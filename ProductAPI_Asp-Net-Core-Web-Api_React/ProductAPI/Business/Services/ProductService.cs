using AutoMapper;
using Business.Interfaces;
using DataAccess.Entities;
using DataAccess.Repositories.IRepositories;
using DTO.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Utils;

namespace Business.Services
{
    public class ProductService : GenericService<ProductEntities, ProductDTO>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper) : base(productRepository, mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetWhereAsync(int? desiredCategoryId = null, decimal? maxPrice = null)
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

            // Filtrelenmiş ürünleri alıyoruz ve Entity'den DTO'ya dönüştürüyoruz
            var filteredEntities = await _productRepository.GetWhereAsync(predicate);
            return _mapper.Map<IEnumerable<ProductDTO>>(filteredEntities);


        }

    }
}
