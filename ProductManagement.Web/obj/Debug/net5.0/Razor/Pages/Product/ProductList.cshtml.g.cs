#pragma checksum "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46861d999401dd19d92ceca3d600c4211d02b637"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46861d999401dd19d92ceca3d600c4211d02b637", @"/Pages/Product/ProductList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a1e0115b8053fd2e2336946069332c262ad85e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Product_ProductList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductManagement.Application.ViewModels.ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "../Shared/_MessageView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure you want to delete?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>ProductList</h1>\r\n\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46861d999401dd19d92ceca3d600c4211d02b6376582", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"input-group mb-3\">\r\n    <input type=\"text\" class=\"form-control\" id=\"txtSearch\" placeholder=\"Search by name\" aria-label=\"Search\"");
            BeginWriteAttribute("value", " value=\"", 282, "\"", 311, 1);
#nullable restore
#line 8 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
WriteAttributeValue("", 290, ViewBag.SearchString, 290, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-describedby=\"button-addon2\">\r\n    <button class=\"btn btn-outline-secondary\" Onclick=\"Search()\" type=\"button\" id=\"button-addon2\">Serach</button>\r\n</div>\r\n<table id=\"book\" class=\"table table-bordered table-hover\">\r\n    <thead>\r\n        <tr");
            BeginWriteAttribute("class", " class=\"", 555, "\"", 563, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <th>Name</th>\r\n            <th>UnitPrice</th>\r\n            <th>ReOrderLevel</th>\r\n            <th>NumberOfUnitsAvailable</th>\r\n            <th>Edit</th>\r\n            <th>Delete</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
         if (Model != null && Model.Products != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr style=\"height: 60px;\">\r\n                    <td>");
#nullable restore
#line 28 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                   Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                   Write(product.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                   Write(product.ReOrderLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                   Write(product.NumberOfUnitsAvailable);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46861d999401dd19d92ceca3d600c4211d02b63710857", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                                                                                                                 WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46861d999401dd19d92ceca3d600c4211d02b63713643", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt text-white\"></i>Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1376, "~/Product/Delete?id=", 1376, 20, true);
#nullable restore
#line 33 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
AddHtmlAttributeValue("", 1396, product.Id, 1396, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"alert alert-info\" id=\"successMessage\">No records available</p>\r\n");
#nullable restore
#line 40 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 43 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
 if (ViewBag.Page > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" id=\"navPrevious\" onclick=\"pageNavigate(\'Previous\');return false; \"\r\n       class=\"btn btn-default\">\r\n        &laquo; Prev\r\n    </a>\r\n");
#nullable restore
#line 49 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
 if (ViewBag.Page < ViewBag.MaxPage)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <a href=\"#\" id=\"navNext\" onclick=\"pageNavigate(\'Next\');return false;\"\r\n       class=\"btn btn-default\">\r\n        Next &raquo;\r\n    </a>\r\n");
#nullable restore
#line 56 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function Search() {
            debugger;
            var searchVal = GetSearchVal();
            $.ajax({
                url: 'ProductList',
                data: { searchString: searchVal }
            }).done();
        }

        function GetSearchVal() {
            return $(""#txtSearch"").val();
        }

        function pageNavigate(navDirection) {
            debugger;
            var searchtext = GetSearchVal();
            var page = 0;

            if (navDirection == ""Next"") {
                page= ");
#nullable restore
#line 80 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                  Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("+1;\r\n            } else if (navDirection == \"Previous\") {\r\n                page = ");
#nullable restore
#line 82 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                   Write(ViewBag.Page);

#line default
#line hidden
#nullable disable
                WriteLiteral("-1;\r\n            }\r\n            window.location.href = \'");
#nullable restore
#line 84 "E:\git\C#\MyProjects\shavindu94\ProductManagement\ProductManagement\ProductManagement.Web\Pages\Product\ProductList.cshtml"
                               Write(Url.Action("ProductList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("?page=\' + page + \'&searchString=\' + searchtext;\r\n\r\n        }\r\n\r\n\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral(" ");
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
