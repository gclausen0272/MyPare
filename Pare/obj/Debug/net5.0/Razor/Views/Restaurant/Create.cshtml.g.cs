#pragma checksum "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d473f365733db2ac366ea9f726def758ad46a6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurant_Create), @"mvc.1.0.view", @"/Views/Restaurant/Create.cshtml")]
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
#line 1 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\_ViewImports.cshtml"
using Pare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\_ViewImports.cshtml"
using Pare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d473f365733db2ac366ea9f726def758ad46a6d", @"/Views/Restaurant/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62262097ad5527c4d294841d7047f5d2c4c53ed1", @"/Views/_ViewImports.cshtml")]
    public class Views_Restaurant_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Restaurant>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
  
    ViewBag.Title = "New Author";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 6 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 7 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
 using(Html.BeginForm()){

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"form-group\">\r\n    ");
#nullable restore
#line 9 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
Write(Html.TextBoxFor(model => model.SessionID, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n  </div>\r\n  <div class=\"form-group\">\r\n    ");
#nullable restore
#line 13 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
Write(Html.TextBoxFor(model => model.SessionID, new { @class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n  </div>\r\n");
            WriteLiteral("  <button onclick = \"getRest(40, 73)\">Submit</button>\r\n");
#nullable restore
#line 18 "C:\Users\gclau\OneDrive\Desktop\Pare\Views\Restaurant\Create.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Restaurant> Html { get; private set; }
    }
}
#pragma warning restore 1591
