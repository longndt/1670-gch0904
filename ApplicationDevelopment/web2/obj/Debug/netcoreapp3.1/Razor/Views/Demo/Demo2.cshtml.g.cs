#pragma checksum "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\Demo\Demo2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be0202c89fe33006ee7376e640cb2ea991d2400"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Demo_Demo2), @"mvc.1.0.view", @"/Views/Demo/Demo2.cshtml")]
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
#line 1 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\_ViewImports.cshtml"
using web2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\_ViewImports.cshtml"
using web2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be0202c89fe33006ee7376e640cb2ea991d2400", @"/Views/Demo/Demo2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f0d3e607999d9f0dbeff71de83083377b731857", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Demo_Demo2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>DEMO 2</h1>\r\n");
#nullable restore
#line 2 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\Demo\Demo2.cshtml"
Write(ViewBag.Greenwich);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 3 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\Demo\Demo2.cshtml"
Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 4 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\Demo\Demo2.cshtml"
 foreach (var thanhpho in @ViewBag.City)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\Demo\Demo2.cshtml"
Write(thanhpho);

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\workspace\1670-gch0904\ApplicationDevelopment\web2\Views\Demo\Demo2.cshtml"
             
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
