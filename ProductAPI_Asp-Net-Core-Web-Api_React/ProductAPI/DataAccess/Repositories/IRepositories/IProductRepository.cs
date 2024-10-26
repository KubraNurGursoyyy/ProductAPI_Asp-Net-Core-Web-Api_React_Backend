﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.IRepositories
{
    public interface IProductRepository : IGenericRepository<ProductEntities> 
    {
        Task<IEnumerable<ProductEntities>> GetWhereAsync(Expression<Func<ProductEntities, bool>> predicate); // Filtreleme
    }
}
