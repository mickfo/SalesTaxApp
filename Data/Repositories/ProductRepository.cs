using Microsoft.EntityFrameworkCore;
using SalesTaxApp.Data.Interfaces;
using SalesTaxApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesTaxApp.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationContext _appDbContext;
        public ProductRepository(ApplicationContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Product> Products => _appDbContext.Products;

        public Product GetProductById(int productId)
        {
           return _appDbContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}
