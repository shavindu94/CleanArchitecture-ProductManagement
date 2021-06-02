using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManagement.Application.Common;
using ProductManagement.Application.Common.Exceptions;
using ProductManagement.Application.Interfaces;
using ProductManagement.Application.ViewModels;
using ProductManagement.Web.Common.Services;
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
        private readonly IUserService _userService;
        private readonly IMessageService _messageService;

        public ProductController(IProductService productService , ILogger<ProductController> log, IUserService userService, IMessageService messageService)
        {
            _productService = productService;
            _userService = userService;
            _messageService = messageService;
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
                _messageService.SetMessage(this, "Created Successfully!","Success");
                ModelState.Clear();
                return View("../Product/CreateProduct", new CreateProductViewModel());
            }
            catch (Exception ex)
            {
                _messageService.SetErrorMessage(this, "Product Creation failed", "Error" ,ex.ToString());
                return View("../Product/CreateProduct", createProductViewModel);
            }
          
        }


        public async Task<IActionResult> Edit(Guid id)
        {
            try
            {
                EditProductViewModel editProductViewModel = await _productService.GetById(id);
                return View("../Product/Edit", editProductViewModel);
            }
            catch (NotFoundException ex)
            {
                _messageService.SetMessage(this, "Product not available", "Warning");
                return View("../Product/ProductList", await GetProductPaginatedList());
            }
            catch (Exception ex)
            {
                _messageService.SetErrorMessage(this, "Product Load failed", "Error", ex.ToString());
                return View("../Product/ProductList", await GetProductPaginatedList());
            }
           
            

            

        }

        public async Task<IActionResult> EditSubmit(EditProductViewModel editProductViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("../Product/Edit", editProductViewModel);
                }

                 editProductViewModel.CraeatedBy = _userService.GetLoggedUserId();
                 await  _productService.UpdateProduct(editProductViewModel);
                _messageService.SetMessage(this, "Product :" + editProductViewModel.Name +  " Updated Successfully!", "Success");
                ModelState.Clear();
                return View("../Product/Edit", new EditProductViewModel());
            }
            catch (NotFoundException ex)
            {
                _messageService.SetMessage(this, "Product not available", "Warning");;
                return View("../Product/Edit", editProductViewModel);
            }
            catch (ConcurrencyException ex)
            {
                string message = "";
                _messageService.SetMessage(this, "Product updated by another user please load the product again", "Warning"); ;
                return View("../Product/Edit", editProductViewModel);
            }
            catch (Exception ex)
            {
                _messageService.SetErrorMessage(this, "Product : " +editProductViewModel.Name +"  update failed", "Error", ex.ToString());
                return View("../Product/Edit", editProductViewModel);
            }

        }

        public async Task<IActionResult> Delete(Guid id)
        {
            try
            {
                await _productService.Delete(id);
                ProductViewModel productViewModel = await GetProductPaginatedList();
                _messageService.SetMessage(this, "Product Deleted Successfully!", "Success");
                return View("../Product/ProductList", productViewModel);
            }
            catch (NotFoundException ex)
            {
                _messageService.SetMessage(this, "Product not available", "Warning");
                return View("../Product/ProductList", await GetProductPaginatedList());
            }
            catch (Exception ex)
            {
                _messageService.SetErrorMessage(this, "Product delete failed", "Error", ex.ToString());
                return View("../Product/ProductList", await GetProductPaginatedList());
            }
           
        }


        public async Task<IActionResult> ProductList(int page = 1, string searchString= "")
        {
            ProductViewModel productViewModel = await GetProductPaginatedList(page, searchString);
            return View("../Product/ProductList", productViewModel);       
        }

        public IActionResult Create()
        {
            return View("../Product/CreateProduct", new CreateProductViewModel());
        }

        private async Task<ProductViewModel> GetProductPaginatedList(int page = 1, string searchString = "")
        {
            try
            {
                var paginationObj = await _productService.GetProductsAsync(new Pagination() { PageNumber = page, PageSize = 10, SearchString = searchString });

                this.ViewBag.MaxPage = paginationObj.NumberOfpages;
                this.ViewBag.Page = page;
                this.ViewBag.SearchString = searchString;
                ModelState.Clear();
                return (ProductViewModel)paginationObj.Data;
            }
            catch (Exception ex)
            {
                _messageService.SetErrorMessage(this, "Product list load failed", "Error", ex.ToString());
                return new ProductViewModel();
            }
           
        }
    }
}
