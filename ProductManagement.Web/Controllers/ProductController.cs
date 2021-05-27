using Microsoft.AspNetCore.Mvc;
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
            TempData["Success"] = "Added Successfully!";
            return View("../Product/CreateProduct", new CreateProductViewModel());
        }

        public IActionResult ProductList()
        {
            return View("../Product/ProductList", _productService.GetProducts());
        }

        public IActionResult CreateProduct()
        {
            return View("../Product/CreateProduct", new CreateProductViewModel());
        }
    }
}
