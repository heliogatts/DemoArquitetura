using System.Collections.Generic;
using System.Linq;
using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;

namespace ArquiteturaDemo.Infra.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository 
    {
        public IEnumerable<Product> GetByPrice(decimal price)
        {
            return Context.Set<Product>().Where(p => p.Price == price).ToList();
        }
    }
}
