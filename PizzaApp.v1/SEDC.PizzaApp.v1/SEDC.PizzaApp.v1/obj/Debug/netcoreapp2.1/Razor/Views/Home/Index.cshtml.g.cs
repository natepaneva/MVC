#pragma checksum "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46d6241ef7f59c241044b719c59456eef8d7083d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d6241ef7f59c241044b719c59456eef8d7083d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2d404ee88b4055dec67b5a8bd56ee776b7bc5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 188, true);
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<h1 class=\"intro text-center\">PizzApp</h1>\r\n<h3 class=\"text-center\">Welcome to the best app for ordering Pizza</h3>\r\n<br />\r\n<br />\r\n<div class=\"text-center\">\r\n    ");
            EndContext();
            BeginContext(189, 139, false);
#line 9 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Home\Index.cshtml"
Write(Html.ActionLink("Click here to order", "Create", "Order", null, new { @class = "btn btn-intro btn-success btn-primary", @id = "orderBtn" }));

#line default
#line hidden
            EndContext();
            BeginContext(328, 42, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
