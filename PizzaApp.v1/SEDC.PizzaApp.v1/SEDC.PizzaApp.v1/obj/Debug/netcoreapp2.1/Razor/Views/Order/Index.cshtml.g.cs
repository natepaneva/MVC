#pragma checksum "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f9fe03588b1fe817becb37e8ccb7ac1b1630719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Index.cshtml", typeof(AspNetCore.Views_Order_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f9fe03588b1fe817becb37e8ccb7ac1b1630719", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2d404ee88b4055dec67b5a8bd56ee776b7bc5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OrderItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(31, 39, true);
            WriteLiteral("<br />\r\n   \r\n\r\n<h1 class=\"text-center\">");
            EndContext();
            BeginContext(71, 13, false);
#line 7 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Index.cshtml"
                   Write(ViewBag.Title);

#line default
#line hidden
            EndContext();
            BeginContext(84, 86, true);
            WriteLiteral("</h1>\r\n\r\n<h2 class=\"text-center\">List of all orders</h2>\r\n\r\n<br />\r\n<br />\r\n\r\n<ul>\r\n\r\n");
            EndContext();
            BeginContext(242, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(248, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50314db72748489c95c10f787bc09e5a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 18 "C:\Users\CDHV2\Desktop\nate\MVC-SEDC\Exercises\PizzaApp.v1\SEDC.PizzaApp.v1\SEDC.PizzaApp.v1\Views\Order\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Orders);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(290, 29, true);
            WriteLiteral("\r\n\r\n</ul>\r\n<br />\r\n<br />\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
