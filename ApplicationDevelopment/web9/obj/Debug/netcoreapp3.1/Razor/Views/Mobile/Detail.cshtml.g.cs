#pragma checksum "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c60d53ec729ee9cb76518546ab1281acc87d9881"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_Detail), @"mvc.1.0.view", @"/Views/Mobile/Detail.cshtml")]
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
#nullable restore
#line 1 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\_ViewImports.cshtml"
using web9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\_ViewImports.cshtml"
using web9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c60d53ec729ee9cb76518546ab1281acc87d9881", @"/Views/Mobile/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc5f0472279017970a04f32f9add5c3b3d3807e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mobile_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<web9.Models.Mobile>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col\">\r\n        <div class=\"card\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 115, "\"", 133, 1);
#nullable restore
#line 6 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
WriteAttributeValue("", 121, Model.Image, 121, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"400\" />\r\n        </div>\r\n    </div>\r\n    <div class=\"col\">\r\n        <div class=\"card bg-light\">\r\n            <h2 class=\"alert alert-success\">");
#nullable restore
#line 11 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h4 class=\"text text-primary\">Brand Name: ");
#nullable restore
#line 12 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
                                                 Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h4 class=\"text text-primary\">Mobile Color: ");
#nullable restore
#line 13 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
                                                   Write(Model.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <h4 class=\"text text-primary\">Mobile Price: ");
#nullable restore
#line 14 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
                                                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</h4>\r\n");
#nullable restore
#line 15 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
             if (Model.Quantity >= 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4 class=\"text text-primary\">In-stock: ");
#nullable restore
#line 17 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
                                                   Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 18 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
            } else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <h4 class=\"text text-warning\">Out of stock</h4>\r\n");
#nullable restore
#line 21 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h4 class=\"text text-primary\">Manufacturing Date: ");
#nullable restore
#line 22 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
                                                         Write(Model.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 23 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
             if (Model.BestSeller == true)
           {

#line default
#line hidden
#nullable disable
            WriteLiteral("               <h3 class=\"text text-danger font-italic\">Best-seller</h3>\r\n");
#nullable restore
#line 26 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Detail.cshtml"
           }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<web9.Models.Mobile> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591