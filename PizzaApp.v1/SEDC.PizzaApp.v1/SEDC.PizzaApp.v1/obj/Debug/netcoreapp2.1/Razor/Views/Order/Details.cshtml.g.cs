#pragma checksum "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "155696e1eb09145801146180e8b52c11ca141588"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Details.cshtml", typeof(AspNetCore.Views_Order_Details))]
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
#line 1 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.v1;

#line default
#line hidden
#line 2 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.v1.Models;

#line default
#line hidden
#line 3 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.v1.Models.Domain;

#line default
#line hidden
#line 4 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.v1.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.v1.Models.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"155696e1eb09145801146180e8b52c11ca141588", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2d404ee88b4055dec67b5a8bd56ee776b7bc5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderDetailsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 12, true);
            WriteLiteral("<br />\r\n\r\n\r\n");
            EndContext();
#line 4 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(55, 66, true);
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n\r\n<h3 class=\"text-center\">Details</h3>\r\n\r\n");
            EndContext();
            BeginContext(147, 366, true);
            WriteLiteral(@"<br />

<table class=""table"">
    <thead>
        <tr>
            <th class=""text-center"">Order name</th>
            <th class=""text-center"">Order phone</th>
            <th class=""text-center"">Pizza name</th>
            <th class=""text-center"">Pizza size</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td class=""text-center""> ");
            EndContext();
            BeginContext(514, 33, false);
#line 27 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Details.cshtml"
                                Write(Html.DisplayFor(x => x.OrderName));

#line default
#line hidden
            EndContext();
            BeginContext(547, 44, true);
            WriteLiteral("</td>\r\n            <td class=\"text-center\"> ");
            EndContext();
            BeginContext(592, 34, false);
#line 28 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Details.cshtml"
                                Write(Html.DisplayFor(x => x.OrderPhone));

#line default
#line hidden
            EndContext();
            BeginContext(626, 44, true);
            WriteLiteral("</td>\r\n            <td class=\"text-center\"> ");
            EndContext();
            BeginContext(671, 33, false);
#line 29 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Details.cshtml"
                                Write(Html.DisplayFor(x => x.PizzaName));

#line default
#line hidden
            EndContext();
            BeginContext(704, 43, true);
            WriteLiteral("</td>\r\n            <td class=\"text-center\">");
            EndContext();
            BeginContext(748, 29, false);
#line 30 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Details.cshtml"
                               Write(Html.DisplayFor(x => x.Price));

#line default
#line hidden
            EndContext();
            BeginContext(777, 48, true);
            WriteLiteral("</td>\r\n        </tr>\r\n    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderDetailsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
