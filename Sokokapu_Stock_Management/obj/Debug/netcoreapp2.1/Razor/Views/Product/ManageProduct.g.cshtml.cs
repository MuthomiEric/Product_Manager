#pragma checksum "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "700c11b9e5e5db6ffa4f7b8020c2e28c3baa2d74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ManageProduct), @"mvc.1.0.view", @"/Views/Product/ManageProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/ManageProduct.cshtml", typeof(AspNetCore.Views_Product_ManageProduct))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\_ViewImports.cshtml"
using Sokokapu_Stock_Management;

#line default
#line hidden
#line 2 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\_ViewImports.cshtml"
using Sokokapu_Stock_Management.Models;

#line default
#line hidden
#line 3 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\_ViewImports.cshtml"
using Sokokapu_Stock_Management.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"700c11b9e5e5db6ffa4f7b8020c2e28c3baa2d74", @"/Views/Product/ManageProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980e65ccd38f7dde60e72fa98ed9a4fd19e5f682", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ManageProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Sokokapu_Stock_Management.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Sold", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
  
    ViewData["Title"] = "ManageProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 37, true);
            WriteLiteral("\r\n<h2>ManageProduct</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(197, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ff7ddf462354916903ebf79c3f484f7", async() => {
                BeginContext(220, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(234, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(327, 47, false);
#line 17 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(374, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(430, 47, false);
#line 20 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(477, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(533, 41, false);
#line 23 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(574, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(630, 41, false);
#line 26 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
            EndContext();
            BeginContext(671, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(727, 44, false);
#line 29 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(771, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(827, 46, false);
#line 32 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberSold));

#line default
#line hidden
            EndContext();
            BeginContext(873, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(929, 40, false);
#line 35 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(969, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1025, 44, false);
#line 38 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1125, 44, false);
#line 41 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1169, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1304, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1365, 46, false);
#line 51 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(1411, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1479, 46, false);
#line 54 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1525, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1593, 40, false);
#line 57 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1701, 40, false);
#line 60 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
            EndContext();
            BeginContext(1741, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1809, 43, false);
#line 63 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1852, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1920, 45, false);
#line 66 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberSold));

#line default
#line hidden
            EndContext();
            BeginContext(1965, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2033, 39, false);
#line 69 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2072, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2140, 43, false);
#line 72 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.ImageUrl));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2251, 48, false);
#line 75 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2299, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2366, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "957a6f0e27a649eea1ee54a64f1f970c", async() => {
                BeginContext(2411, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2419, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2441, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea74f549b011453994aae482d21b161b", async() => {
                BeginContext(2489, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 79 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
                                              WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2500, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2522, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62e5d4cf20c440dba9a3c4cbfd7c048a", async() => {
                BeginContext(2567, 11, true);
                WriteLiteral("Number Sold");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 80 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
                                           WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2582, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2667, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 84 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\ManageProduct.cshtml"
        }

#line default
#line hidden
            BeginContext(2720, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Sokokapu_Stock_Management.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
