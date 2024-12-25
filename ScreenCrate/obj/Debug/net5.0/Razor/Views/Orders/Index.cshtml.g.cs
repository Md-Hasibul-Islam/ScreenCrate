#pragma checksum "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "258b7eefee9bf15b5567341a75a5639d7e7f4485"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\_ViewImports.cshtml"
using ScreenCrate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\_ViewImports.cshtml"
using ScreenCrate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"258b7eefee9bf15b5567341a75a5639d7e7f4485", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e1220a3678d643d52a7714e122511ac94254a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
   
    ViewData["Title"] = "List of Orders";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <p>
            <h3>List of movies you currently own</h3>
        </p>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Order ID</th>
                    <th>Movie Name</th>
                    <th>Paid Amount</th>
");
#nullable restore
#line 19 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("User"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th></th>\n");
#nullable restore
#line 22 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <th>User</th>\n");
#nullable restore
#line 26 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\n            </thead>\n            <tbody>\n");
#nullable restore
#line 30 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td class=\"align-middle\">");
#nullable restore
#line 33 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                    <td class=\"align-middle\">\n                        <ul style=\"list-style-type:none\">\n");
#nullable restore
#line 37 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                             foreach (var item in order.OrderItems)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li style=\"margin-left:-45px; margin-right:45px;\">\n                    <div class=\"alert alert-info\" role=\"alert\">\n                        <!--<span class=\"badge bg-success\">");
#nullable restore
#line 41 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                                                      Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> [৳");
#nullable restore
#line 41 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                                                                            Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("]--><b>");
#nullable restore
#line 41 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                                                                                                            Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n                    </div>\n                </li>");
#nullable restore
#line 43 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n                    </td>\n\n                    <td class=\"align-middle\">\n                        ৳");
#nullable restore
#line 48 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                    Write(order.OrderItems.Select(m => m.Movie.Price * m.Amount).Sum());

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--.ToString(\"c\")-->\n                    </td>\n\n");
#nullable restore
#line 51 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("User"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-left\">\r\n");
#nullable restore
#line 54 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                         foreach (var item in order.OrderItems)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-outline-danger float-right\"");
            BeginWriteAttribute("href", " href=\"", 1997, "\"", 2053, 1);
#nullable restore
#line 56 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
WriteAttributeValue("", 2004, Url.Action("Stream", new { id = item.Movie.Id }), 2004, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <i class=\"bi bi-collection-play\"></i> Stream Now\r\n                            </a>\r\n");
#nullable restore
#line 59 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n");
#nullable restore
#line 61 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                     if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"align-middle\"> ");
#nullable restore
#line 65 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                                             Write(order.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>");
#nullable restore
#line 65 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\n");
#nullable restore
#line 67 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n        </table>\n\n    </div>\n</div>");
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
