using ProductManagement.Application.Interfaces;
using ProductManagement.Application.ViewModels;
using ProductManagement.Domain.Interfaces;
using ProductManagement.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Services
{
    public class ProductService:IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService (IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ProductViewModel GetProducts()
        {
            return new ProductViewModel
            {
                Products = _unitOfWork.Products.GetAll()
            };
        }

        public void CreateProduct(CreateProductViewModel createProductViewModel)
        {
            Product product = new Product()
            {
                Name = createProductViewModel.Name,
                UnitPrice = createProductViewModel.UnitPrice,
                ReOrderLevel = createProductViewModel.ReOrderLevel,
                NumberOfUnitsAvailable = createProductViewModel.NumberOfUnitsAvailable,
                CreatedUserId = "Admin",
                CreatedDate =DateTime.Now
            };

            _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
        }
    }
}
