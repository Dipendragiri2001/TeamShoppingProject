using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.EFCore.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationContext context ): base(context)
        {

        }

        public IEnumerable<Product> GetPopularProducts(int count)
        {
            throw new NotImplementedException();
        }
    }
}
