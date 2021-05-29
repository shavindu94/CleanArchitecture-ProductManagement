using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductManagement.Application.Common;
using ProductManagement.Application.Interfaces;
using ProductManagement.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductManagement.Web.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        readonly ILogger<ProductController> _log;
        public ProductController(IProductService productService , ILogger<ProductController> log)
        {
            _productService = productService;
            _log = log;
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

                _productService.CreateProduct(createProductViewModel);
                TempData["Success"] = "Added Successfully!";
                _log.LogTrace(DateTime.Now + "| Product " + createProductViewModel.Name + "created successfully");
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

                _productService.UpdateProduct(editProductViewModel);
                TempData["Success"] = "Updated Successfully!";
                _log.LogTrace(DateTime.Now + "| Product " + editProductViewModel.Name + "updated successfully");
                return View("../Product/CreateProduct", new EditProductViewModel());
            }
            catch (Exception ex)
            {
                string message = "Product update failed";
                _log.LogError(message + ":" + ex.ToString());
                TempData["Error"] = message;
                return View("../Product/Edit", editProductViewModel);
            }

        }

        public IActionResult Delete(Guid id)
        {
            try
            {
                _productService.Delete(id);
                ProductViewModel productViewModel = GetProductPaginatedList();
                TempData["Success"] = "Product deleted successfully!";
               _log.LogTrace(DateTime.Now + "| Product id " + id  + "deleted successfully");
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


        public IActionResult ProductList(int page = 1, string searchString= "")
        {
            try
            {
                ProductViewModel productViewModel = GetProductPaginatedList(page, searchString);
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

        private ProductViewModel GetProductPaginatedList(int page = 1, string searchString = "")
        {
            var paginationObj = _productService.GetProducts(new Pagination() { PageNumber = page, PageSize = 10, SearchString = searchString });

            this.ViewBag.MaxPage = paginationObj.NumberOfpages;
            this.ViewBag.Page = page;
            this.ViewBag.SearchString = searchString;
            ModelState.Clear();
            return (ProductViewModel) paginationObj.Data;
        }
    }
}
