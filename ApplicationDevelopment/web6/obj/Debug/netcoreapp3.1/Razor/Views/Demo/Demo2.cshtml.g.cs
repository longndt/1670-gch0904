#pragma checksum "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6397af4a6d3a16e0fb293b9f3e83aa228b88bb3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6397af4a6d3a16e0fb293b9f3e83aa228b88bb3", @"/Views/Demo/Demo2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6883bd03627852bb01d7a468dda74fda41fd1890", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Demo_Demo2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>I am living in <u>");
#nullable restore
#line 1 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
                Write(ViewBag.Vietnam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></p>\r\n<br />\r\n\r\n");
#nullable restore
#line 5 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
  
    var names = ViewBag.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
 foreach (var name in names)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text text-primary\">");
#nullable restore
#line 15 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
                             Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 16 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 21 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
 for (var i = 0; i < names.Count; i++)
{
    var j = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"text text-success\">");
#nullable restore
#line 24 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
                             Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 24 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
                                  Write(names[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 25 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered text-center\">\n    <thead>\r\n        <tr>\r\n            <th class=\"text text-danger\">Person Id</th>\r\n            <th class=\"text text-danger\">Person Name</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
         for (var i = 0; i < names.Count; i++)
        {
            var j = i + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"text text-warning\">");
#nullable restore
#line 38 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
                                         Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text text-warning\">");
#nullable restore
#line 39 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
                                         Write(names[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 41 "C:\workspace\1670-gch0904\ApplicationDevelopment\web6\Views\Demo\Demo2.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\n");
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