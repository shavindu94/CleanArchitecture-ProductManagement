﻿using ProductManagement.Application.Common;
using ProductManagement.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.Application.Interfaces
{
    public interface IProductService
    {
        ProductViewModel GetProducts();

        void CreateProduct(CreateProductViewModel createProductViewModel);

        Task<EditProductViewModel> GetById(Guid id);

        Task UpdateProduct(EditProductViewModel editProductViewModel);

        Task Delete(Guid id);

        Task<Pagination> GetProductsAsync(Pagination paginationIn);

    }
}
