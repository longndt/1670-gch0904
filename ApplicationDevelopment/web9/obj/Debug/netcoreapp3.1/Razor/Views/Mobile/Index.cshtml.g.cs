#pragma checksum "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a1fadf38eabe078c03680dec4b78958c18392c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mobile_Index), @"mvc.1.0.view", @"/Views/Mobile/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1fadf38eabe078c03680dec4b78958c18392c1", @"/Views/Mobile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdc5f0472279017970a04f32f9add5c3b3d3807e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Mobile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ICollection<web9.Models.Mobile>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-success"">
    <thead>
        <tr>
            <th colspan=""6"" class=""alert alert-danger"">Mobile List</th>
        </tr>
        <tr>
            <th>Mobile Id</th>
            <th>Mobile Name</th>
            <th>Mobile Brand</th>
            <th>Mobile Color</th>
            <th>Mobile Price</th>
            <th>Mobile Image</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 18 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
         foreach (var mobile in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\n                <td>");
#nullable restore
#line 21 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
               Write(mobile.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
               Write(mobile.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
               Write(mobile.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
               Write(mobile.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
               Write(mobile.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n                <td>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 764, "\"", 783, 1);
#nullable restore
#line 27 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
WriteAttributeValue("", 770, mobile.Image, 770, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" height=\"100\">\r\n                </td>\r\n           </tr>\n");
#nullable restore
#line 30 "C:\workspace\1670-gch0904\ApplicationDevelopment\web9\Views\Mobile\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ICollection<web9.Models.Mobile>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
