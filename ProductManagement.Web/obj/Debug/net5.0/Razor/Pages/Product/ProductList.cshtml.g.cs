#pragma checksum "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823bf150191bc30dca44dd80b2220d5c57d0f5ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ProductManagement.Web.Pages.Product.Pages_Product_ProductList), @"mvc.1.0.view", @"/Pages/Product/ProductList.cshtml")]
namespace ProductManagement.Web.Pages.Product
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\_ViewImports.cshtml"
using ProductManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\_ViewImports.cshtml"
using ProductManagement.Infrastructure.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823bf150191bc30dca44dd80b2220d5c57d0f5ea", @"/Pages/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a1e0115b8053fd2e2336946069332c262ad85e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductManagement.Application.ViewModels.ProductViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>List</h1>\r\n\r\n<h4>Product</h4>\r\n<hr />\r\n<table id=\"book\" class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr");
            BeginWriteAttribute("class", " class=\"", 195, "\"", 203, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <th>Name</th>\r\n            <th>UnitPrice</th>\r\n            <th>ReOrderLevel</th>\r\n            <th>NumberOfUnitsAvailable</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
         foreach (var product in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"height: 60px;\">\r\n                <td>");
#nullable restore
#line 20 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
               Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
               Write(product.ReOrderLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
               Write(product.NumberOfUnitsAvailable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductManagement.Application.ViewModels.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
