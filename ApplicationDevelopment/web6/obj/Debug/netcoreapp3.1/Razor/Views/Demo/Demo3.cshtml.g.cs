#pragma checksum "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a392005e61b04af5411b2e3d9e3ad9cc661f5bc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Demo3), @"mvc.1.0.view", @"/Views/Demo/Demo3.cshtml")]
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
#line 1 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\_ViewImports.cshtml"
using web6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\_ViewImports.cshtml"
using web6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a392005e61b04af5411b2e3d9e3ad9cc661f5bc3", @"/Views/Demo/Demo3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6883bd03627852bb01d7a468dda74fda41fd1890", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Demo_Demo3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mobile>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"table table-danger\">\r\n    <tr>\r\n        <th>Mobile No.</th>\r\n        <th>Mobile Name</th>\r\n        <th>Mobile Quantity</th>\r\n        <th>Mobile Price</th>\r\n    </tr>\r\n");
#nullable restore
#line 10 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml"
     foreach (var m in Model) 
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <tr>\r\n           <td>");
#nullable restore
#line 13 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml"
          Write(m.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 14 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml"
          Write(m.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 15 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml"
          Write(m.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 16 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml"
          Write(m.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</td>\r\n       </tr>\r\n");
#nullable restore
#line 18 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo3.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mobile>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591