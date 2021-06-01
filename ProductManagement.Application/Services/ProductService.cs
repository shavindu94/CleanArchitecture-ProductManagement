using ProductManagement.Application.Common;
using ProductManagement.Application.Common.Exceptions;
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

        public async Task<Pagination> GetProductsAsync(Pagination paginationIn)
        {
           var list = await _unitOfWork.Products.GetFilteredListAsync(paginationIn.SearchString, paginationIn.PageNumber, paginationIn.PageSize);

            Pagination pagination = new Pagination()
            {
                PageNumber = paginationIn.PageNumber,
                PageSize = paginationIn.PageSize,
                TotalNumber = _unitOfWork.Products.GetCount(),
                Data = (list != null && list.Any()? new ProductViewModel() { Products = list } : null)
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


        public async Task<EditProductViewModel> GetById(Guid id)
        {
            Product product = await _unitOfWork.Products.GetByIdAsync(id);

            if(product != null && product.Id !=Guid.Empty)
            {
                return new EditProductViewModel()
                {   Id = product.Id,
                    Name = product.Name,
                    UnitPrice = product.UnitPrice,
                    ReOrderLevel = product.ReOrderLevel,
                    NumberOfUnitsAvailable = product.NumberOfUnitsAvailable,
                    RowVersion=product.RowVersion
                };

            }
            else
            {
                throw new NotFoundException("Product not found Id :" + id.ToString());
            }
        }

        public async Task UpdateProduct(EditProductViewModel editProductViewModel)
        {

            Product product = await _unitOfWork.Products.GetByIdAsync(editProductViewModel.Id);

            if (product != null && product.Id != Guid.Empty)
            {
                if (product.RowVersion.SequenceEqual(editProductViewModel.RowVersion))
                {
                    product.Id = editProductViewModel.Id;
                    product.Name = editProductViewModel.Name;
                    product.UnitPrice = editProductViewModel.UnitPrice;
                    product.ReOrderLevel = editProductViewModel.ReOrderLevel;
                    product.NumberOfUnitsAvailable = editProductViewModel.NumberOfUnitsAvailable;
                    product.ModifiedUserId = editProductViewModel.CraeatedBy;
                    product.ModifiedDate = DateTime.Now;
                    product.RowVersion = editProductViewModel.RowVersion;

                    _unitOfWork.Products.Update(product);
                    await _unitOfWork.CompleteAsync();
                }
                else
                {
                    throw new ConcurrencyException(editProductViewModel.Name, editProductViewModel.Id.ToString());
                }
            }
            else
            {
                throw new NotFoundException( editProductViewModel.Name, editProductViewModel.Id.ToString());
            }
            
        }

        public async Task Delete(Guid id)
        {
            Product product = await _unitOfWork.Products.GetByIdAsync(id);

            if (product != null && product.Id != Guid.Empty)
            {
                _unitOfWork.Products.Remove(product);
                _unitOfWork.Complete();
            }
            else
            {
                throw new NotFoundException("Product not found Id :" + id.ToString());
            }

        }
    }
}
