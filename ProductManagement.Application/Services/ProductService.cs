using ProductManagement.Application.Common;
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

        public Pagination GetProducts(Pagination paginationIn)
        {
           var list =_unitOfWork.Products.GetFiletedList(paginationIn.SearchString, paginationIn.PageNumber, paginationIn.PageSize);

            Pagination pagination = new Pagination()
            {
                PageNumber = paginationIn.PageNumber,
                PageSize = paginationIn.PageSize,
                TotalNumber = _unitOfWork.Products.GetCount(),
                Data = (list != null && list.Count != 0 ? new ProductViewModel() { Products = list } : null)
            };
            return pagination;
        }

        public void CreateProduct(CreateProductViewModel createProductViewModel)
        {
            Product product = new Product()
            {
                Name = createProductViewModel.Name,
                UnitPrice = createProductViewModel.UnitPrice,
                ReOrderLevel = createProductViewModel.ReOrderLevel,
                NumberOfUnitsAvailable = createProductViewModel.NumberOfUnitsAvailable,
                CreatedUserId = createProductViewModel.CraeatedBy,
                CreatedDate =DateTime.Now
            };

            _unitOfWork.Products.Add(product);
            _unitOfWork.Complete();
        }


        public EditProductViewModel GetById(Guid id)
        {
            Product product = _unitOfWork.Products.GetById(id);

            if(product != null && product.Id !=Guid.Empty)
            {
                return new EditProductViewModel()
                {   Id = product.Id,
                    Name = product.Name,
                    UnitPrice = product.UnitPrice,
                    ReOrderLevel = product.ReOrderLevel,
                    NumberOfUnitsAvailable = product.NumberOfUnitsAvailable
                };

            }
            return new EditProductViewModel();
        }

        public void UpdateProduct(EditProductViewModel editProductViewModel)
        {
            Product product = _unitOfWork.Products.GetById(editProductViewModel.Id);

            product.Id = editProductViewModel.Id;
            product.Name = editProductViewModel.Name;
            product.UnitPrice = editProductViewModel.UnitPrice;
            product.ReOrderLevel = editProductViewModel.ReOrderLevel;
            product.NumberOfUnitsAvailable = editProductViewModel.NumberOfUnitsAvailable;
            product.ModifiedUserId = editProductViewModel.CraeatedBy;
            product.ModifiedDate = DateTime.Now;
            
            _unitOfWork.Complete();
        }

        public void Delete(Guid id)
        {
            Product product = _unitOfWork.Products.GetById(id);
            _unitOfWork.Products.Remove(product);
            _unitOfWork.Complete();

        }
    }
}
