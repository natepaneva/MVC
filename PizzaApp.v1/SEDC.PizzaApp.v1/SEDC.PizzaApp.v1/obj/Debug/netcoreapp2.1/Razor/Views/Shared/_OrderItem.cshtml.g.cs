#pragma checksum "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab85d8e53bf4b2712550b29ec3e35bf5f5976a97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OrderItem), @"mvc.1.0.view", @"/Views/Shared/_OrderItem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_OrderItem.cshtml", typeof(AspNetCore.Views_Shared__OrderItem))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab85d8e53bf4b2712550b29ec3e35bf5f5976a97", @"/Views/Shared/_OrderItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2d404ee88b4055dec67b5a8bd56ee776b7bc5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OrderItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(60, 448, true);
            WriteLiteral(@"

    <table class=""table"">
        <thead>
            <tr>
                <th class=""text-center"">#</th>
                <th class=""text-center"">User info</th>
                <th class=""text-center"">Pizza name</th>
                <th class=""text-center"">Pizza Size</th>
                <th class=""text-center"">Total price</th>
                <th class=""text-center"">Photo</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 16 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
             foreach (var order in Model)
            {

#line default
#line hidden
            BeginContext(566, 66, true);
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(633, 83, false);
#line 19 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
                                       Write(Html.ActionLink("Order no. " + order.Id, "Details", "Order", new { id = order.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(716, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(768, 20, false);
#line 20 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
                                       Write(order.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(788, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(790, 19, false);
#line 20 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
                                                             Write(order.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(809, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(861, 16, false);
#line 21 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
                                       Write(order.Pizza.Name);

#line default
#line hidden
            EndContext();
            BeginContext(877, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(929, 16, false);
#line 22 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
                                       Write(order.Pizza.Size);

#line default
#line hidden
            EndContext();
            BeginContext(945, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">");
            EndContext();
            BeginContext(997, 11, false);
#line 23 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
                                       Write(order.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1008, 240, true);
            WriteLiteral("</td>\r\n                    <td class=\"text-center\">\r\n                        <img src=\"https://www.cicis.com/wp-content/uploads/2019/04/pizza_categoryheader.png\" alt=\"Pizza\" height=\"50\" />\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Shared\_OrderItem.cshtml"
            }

#line default
#line hidden
            BeginContext(1263, 42, true);
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
