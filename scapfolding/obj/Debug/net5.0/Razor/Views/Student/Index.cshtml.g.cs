#pragma checksum "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8aea7ea6f805c7c2b81d23fbe68ec913dac3d9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
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
#line 1 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\_ViewImports.cshtml"
using scapfolding;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\_ViewImports.cshtml"
using scapfolding.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8aea7ea6f805c7c2b81d23fbe68ec913dac3d9d", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236b2fd0a31872e9e8e86e5dc6805b1aa31363c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<scapfolding.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
  
    ViewBag.Title = "Index";

            

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Index</h2>\r\n<p>\r\n    ");
#nullable restore
#line 9 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n</p>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 15 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Roll));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
     foreach ( var sobj in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>\r\n        ");
#nullable restore
#line 26 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelItem => sobj.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 29 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
   Write(Html.DisplayFor(modelItem => sobj.Roll));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
#nullable restore
#line 32 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { id = sobj.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        ");
#nullable restore
#line 33 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
   Write(Html.ActionLink("Details", "Details", new { id = sobj.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        ");
#nullable restore
#line 34 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
   Write(Html.ActionLink("Delete", "Delete", new { id = sobj.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 37 "C:\Users\Allah\source\repos\scapfolding\scapfolding\Views\Student\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<scapfolding.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591