#pragma checksum "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2762a2d8185a872d3f3639058e7ae53924546e67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 4 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 5 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2762a2d8185a872d3f3639058e7ae53924546e67", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242e14b97e85c21e354e1c2b5e97686a6bfd3f2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
      

    Layout = "~/Views/Shared/_Layout.cshtml";

    

#line default
#line hidden
            BeginContext(108, 93, true);
            WriteLiteral("\r\n    <h2 class=\"title\">Sokokapu Product Manager</h2>\r\n\r\n\r\n    <div class=\"display-flex\">\r\n\r\n");
            EndContext();
#line 15 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
         foreach (var item in Model)
        {
        var path = "/images/" + item.ImageUrl;


#line default
#line hidden
            BeginContext(300, 55, true);
            WriteLiteral("        <div class=\"product-container\">\r\n\r\n            ");
            EndContext();
            BeginContext(355, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3fcdbb6ab4348a3bf55b390e2aee918", async() => {
                BeginContext(403, 22, true);
                WriteLiteral("\r\n                <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 425, "\"", 436, 1);
#line 22 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
WriteAttributeValue("", 431, path, 431, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(437, 38, true);
                WriteLiteral(" alt=\"Alternate Text\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
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
            BeginContext(479, 104, true);
            WriteLiteral("\r\n\r\n\r\n            <div class=\"product-container-details\">\r\n\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(584, 46, false);
#line 29 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(630, 87, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"price\">\r\n                    Ksh ");
            EndContext();
            BeginContext(718, 40, false);
#line 32 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(758, 49, true);
            WriteLiteral("\r\n                </div>\r\n                <div>\r\n");
            EndContext();
#line 35 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
                     if (item.InStock == true)
                    {

#line default
#line hidden
            BeginContext(878, 65, true);
            WriteLiteral("                    <span style=\"color:#01a350\">In Stock</span>\r\n");
            EndContext();
#line 38 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
                    }

                    else
                    {

#line default
#line hidden
            BeginContext(1017, 65, true);
            WriteLiteral("                    <span style=\"color:#ee403a\">Sold Out</span>\r\n");
            EndContext();
#line 43 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1105, 60, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 47 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1176, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
