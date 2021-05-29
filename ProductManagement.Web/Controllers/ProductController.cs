using Microsoft.AspNetCore.Mvc;
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
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            ProductViewModel model = _productService.GetProducts();

            return View(model);
        }

        [HttpPost]
        public ViewResult CreateSubmit(CreateProductViewModel createProductViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("../Product/CreateProduct", createProductViewModel);
            }

            _productService.CreateProduct(createProductViewModel);
            ModelState.Clear();
            TempData["Success"] = "Added Successfully!";
            return View("../Product/CreateProduct", new CreateProductViewModel());
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
            if (!ModelState.IsValid)
            {
                return View("../Product/Edit", editProductViewModel);
            }

            _productService.UpdateProduct(editProductViewModel);
            TempData["Success"] = "Updated Successfully!";
            return View("../Product/CreateProduct", new CreateProductViewModel());

        }

        public IActionResult Delete(Guid id)
        {
            _productService.Delete(id);

            return View("../Product/ProductList", _productService.GetProducts());
        }


        public IActionResult ProductList(int page = 1, string searchString= "")
        {

            var paginationObj = _productService.GetProducts(new Pagination() { PageNumber = page, PageSize = 10, SearchString = searchString });


            this.ViewBag.MaxPage = paginationObj.NumberOfpages;

            this.ViewBag.Page = page;

            this.ViewBag.SearchString = searchString;
            ModelState.Clear();

            return View("../Product/ProductList", paginationObj.Data);
        }

        public IActionResult Create()
        {
            return View("../Product/CreateProduct", new CreateProductViewModel());
        }
    }
}
