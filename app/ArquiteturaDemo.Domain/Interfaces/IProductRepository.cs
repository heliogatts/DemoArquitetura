using System.Collections.Generic;
using ArquiteturaDemo.Domain.Entities;

namespace ArquiteturaDemo.Domain.Interfaces
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IEnumerable<Product> GetByPrice(decimal price);
    }
}
