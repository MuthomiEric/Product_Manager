#pragma checksum "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a4aac8cd6302d126a9903b05932189291c88d67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Details.cshtml", typeof(AspNetCore.Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a4aac8cd6302d126a9903b05932189291c88d67", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"242e14b97e85c21e354e1c2b5e97686a6bfd3f2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-back"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";
    var imgpath = "/images/" + Model.ImageUrl;

#line default
#line hidden
            BeginContext(131, 54, true);
            WriteLiteral("\r\n<div class=\"details-div\">\r\n\r\n    <div>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 185, "\"", 199, 1);
#line 12 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml"
WriteAttributeValue("", 191, imgpath, 191, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(200, 91, true);
            WriteLiteral(" alt=\"Product Image\" />\r\n    </div>\r\n    <div>\r\n        <div>\r\n            <p class=\"bold\">");
            EndContext();
            BeginContext(292, 43, false);
#line 16 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml"
                       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(335, 100, true);
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <p class=\"bold\">Description</p><br />\r\n            ");
            EndContext();
            BeginContext(436, 43, false);
#line 20 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(479, 56, true);
            WriteLiteral("\r\n        </div>\r\n        <div><p class=\"bold\">Size</p> ");
            EndContext();
            BeginContext(536, 36, false);
#line 22 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(572, 38, true);
            WriteLiteral("</div>\r\n        <div class=\"bold\">Ksh ");
            EndContext();
            BeginContext(611, 37, false);
#line 23 "C:\Users\TSOMI\Desktop\PROJECTS\GitHub\Sokokapu_Stock_Management\Sokokapu_Stock_Management\Views\Product\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(648, 56, true);
            WriteLiteral("</div>\r\n    </div>\r\n</div>\r\n<div class=\"back-div\">\r\n    ");
            EndContext();
            BeginContext(704, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bafcc6c2d3c64583bdc2b50c9fec1745", async() => {
                BeginContext(743, 43, true);
                WriteLiteral("<i class=\"fas fa-backward\"></i>Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(790, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
