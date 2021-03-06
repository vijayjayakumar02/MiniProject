#pragma checksum "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65c91f02ec5689ba9e6844d4f8514039a406a4a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_OrderSuccess), @"mvc.1.0.view", @"/Views/Customer/OrderSuccess.cshtml")]
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
#line 1 "D:\Training\MiniProject\TastyDots\TastyDots\Views\_ViewImports.cshtml"
using TastyDots;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Training\MiniProject\TastyDots\TastyDots\Views\_ViewImports.cshtml"
using TastyDots.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Training\MiniProject\TastyDots\TastyDots\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c91f02ec5689ba9e6844d4f8514039a406a4a0", @"/Views/Customer/OrderSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d3145a694f57b6b17b20ead32b1360b9dcc6dfc", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_OrderSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TastyDots.Models.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
  
    ViewData["Tilte"] = "Order Placed";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header bg-primary text-white"">
        Order Placed Succesfully
    </div>
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-12 col-sm-6"">
                <h1 class=""text-center"">Order Id: </h1>
            </div>
            <div class=""col-12 col-sm-6"">
                <h3 class=""text-center"">");
#nullable restore
#line 20 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
                                   Write(Model.OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 col-sm-6"">
                <h1 class=""text-center"">Name: </h1>
            </div>
            <div class=""col-12 col-sm-6"">
                <h3 class=""text-center"">");
#nullable restore
#line 28 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
                                   Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-12 col-sm-6"">
                <h1 class=""text-center"">Phone Number: </h1>
            </div>
            <div class=""col-12 col-sm-6"">
                <h3 class=""text-center"">");
#nullable restore
#line 36 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
                                   Write(Model.MobileNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-sm-6\">\r\n                <h1 class=\"text-center\">Dishes: </h1>\r\n            </div>\r\n");
#nullable restore
#line 43 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
             foreach (var item in Model.Item)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 col-sm-6\">\r\n                    <h2 class=\"text-center\">");
#nullable restore
#line 46 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
                                       Write(item.Dish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n");
#nullable restore
#line 48 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"row\">\r\n            <div class=\"col-12 col-sm-6\">\r\n                <h1 class=\"text-center\">Total Cost: </h1>\r\n            </div>\r\n            <div class=\"col-12 col-sm-6\">\r\n                <h2 class=\"text-center\">");
#nullable restore
#line 55 "D:\Training\MiniProject\TastyDots\TastyDots\Views\Customer\OrderSuccess.cshtml"
                                   Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TastyDots.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
