﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManagement.Application.Common;
using ProductManagement.Application.Interfaces;
using ProductManagement.Application.ViewModels;
using ProductManagement.Web.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ILogger<ProductController> _log;
        private readonly IUserService _userService;
        public ProductController(IProductService productService , ILogger<ProductController> log, IUserService userService)
        {
            _productService = productService;
            _log = log;
            _userService = userService;
        }
        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();

            return View(model);
        }

        [HttpPost]
        public ViewResult CreateSubmit(CreateProductViewModel createProductViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("../Product/CreateProduct", createProductViewModel);
                }

                createProductViewModel.CraeatedBy= _userService.GetLoggedUserId();
                _productService.CreateProduct(createProductViewModel);
                TempData["Success"] = "Created Successfully!";
                _log.LogInformation(DateTime.Now + "| Product :" + createProductViewModel.Name + "  created successfully");
                ModelState.Clear();
                return View("../Product/CreateProduct", new CreateProductViewModel());
            }
            catch (Exception ex)
            {
                string message = "Product Creation failed";
                _log.LogError(message +":" + ex.ToString());
                TempData["Error"] = message;
                return View("../Product/CreateProduct", createProductViewModel);
            }
          
        }


        public IActionResult Edit(Guid id)
        {
            EditProductViewModel editProductViewModel = _productService.GetById(id);

            if (editProductViewModel != null && editProductViewModel.Id != Guid.Empty)
            {

                return View("../Product/Edit", editProductViewModel);
            }

            return View("../Product/ProductList", _productService.GetProducts());

        }

        public IActionResult EditSubmit(EditProductViewModel editProductViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("../Product/Edit", editProductViewModel);
                }

                editProductViewModel.CraeatedBy = _userService.GetLoggedUserId();
                _productService.UpdateProduct(editProductViewModel);
                TempData["Success"] = "Updated Successfully!";
                _log.LogInformation(DateTime.Now + "| Product " + editProductViewModel.Name + "updated successfully");
                ModelState.Clear();
                return View("../Product/Edit", new EditProductViewModel());
            }
            catch (Exception ex)
            {
                string message = "Product update failed";
                _log.LogError(message + ":" + ex.ToString());
                TempData["Error"] = message;
                return View("../Product/Edit", editProductViewModel);
            }

        }

        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                _productService.Delete(id);
                ProductViewModel productViewModel = await GetProductPaginatedList();
                TempData["Success"] = "Product deleted successfully!";
               _log.LogInformation(DateTime.Now + "| Product id " + id  + "deleted successfully");
                return View("../Product/ProductList", productViewModel);
            }
            catch (Exception ex)
            {
                string message = "Product delete failed";
                _log.LogError(message + ":" + ex.ToString());
                TempData["Error"] = message;
                return View("../Product/Edit", new ProductViewModel());
            }
           
        }


        public async Task<IActionResult> ProductList(int page = 1, string searchString= "")
        {
            try
            {
                ProductViewModel productViewModel = await GetProductPaginatedList(page, searchString);
                return View("../Product/ProductList", productViewModel);
            }
            catch (Exception ex)
            {
                string message = "Product list load failed";
                _log.LogError(message + ":" + ex.ToString());
                TempData["Error"] = message;
                return View("../Product/Edit", new ProductViewModel());
            }
            
        }

        public IActionResult Create()
        {
            return View("../Product/CreateProduct", new CreateProductViewModel());
        }

        private async Task<ProductViewModel> GetProductPaginatedList(int page = 1, string searchString = "")
        {
            var paginationObj =  await _productService.GetProductsAsync(new Pagination() { PageNumber = page, PageSize = 10, SearchString = searchString });

            this.ViewBag.MaxPage = paginationObj.NumberOfpages;
            this.ViewBag.Page = page;
            this.ViewBag.SearchString = searchString;
            ModelState.Clear();
            return (ProductViewModel) paginationObj.Data;
        }
    }
}
