using ProductManagement.Application.Interfaces;
using ProductManagement.Application.ViewModels;
using ProductManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Services
{
    public class ProductService:IProductService
    {
        public IProductRepository _productRepository;

        public ProductService (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel
            {
                Products = _productRepository.GetAll()
            };
        }
    }
}
