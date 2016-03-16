using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArquiteturaDemo.Domain.Entities;
using ArquiteturaDemo.Domain.Interfaces;

namespace ArquiteturaDemo.UI.Application
{
    public class ProductApplication : ApplicationBase
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Register(Product product)
        {
            BeginTransaction();

            _productRepository.Add(product);

            Commit();
        }
    }
}
