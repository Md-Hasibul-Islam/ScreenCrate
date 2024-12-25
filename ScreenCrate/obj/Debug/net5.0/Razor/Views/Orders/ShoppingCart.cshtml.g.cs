#pragma checksum "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c70544df6a64a1b68f74f7870accf594f3aea8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_ShoppingCart), @"mvc.1.0.view", @"/Views/Orders/ShoppingCart.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
using ScreenCrate.Data.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96c70544df6a64a1b68f74f7870accf594f3aea8", @"/Views/Orders/ShoppingCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e1220a3678d643d52a7714e122511ac94254a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_ShoppingCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Orders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveItemFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Movies", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
  
    ViewData["Title"] = "Shopping Cart Summary";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-8 offset-2"">
        <div class=""text-center"">
            <h2>Your shopping cart summary</h2>
        </div>

        <table class=""table"">
            <thead>
                <tr>
                    <th>Selected amount</th>
                    <th>Movie</th>
                    <th>Price</th>
                    <th>Subtotal</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 25 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                 foreach (var item in Model.ShoppingCart.ShoppingCartItems)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td class=\"align-middle\">");
#nullable restore
#line 28 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                            Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"align-middle\">");
#nullable restore
#line 29 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                            Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td class=\"align-middle\">৳");
#nullable restore
#line 30 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                             Write(item.Movie.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--.ToString(\"c\")--></td>\n                        <td class=\"align-middle\">(৳");
#nullable restore
#line 31 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                               Write(item.Amount*item.Movie.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--.ToString(\"c\")-->)</td>\n                        <td class=\"align-middle\">\n                            <!-- <a class=\"text-danger\" asp-controller=\"Orders\" asp-action=\"RemoveItemFromShoppingCart\"\n                               asp-route-id=\"");
#nullable restore
#line 34 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                        Write(item.Movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                <i class=""bi bi-cart-dash""></i>
                            </a>
                            |
                            <a class=""text-success"" asp-controller=""Orders"" asp-action=""AddItemToShoppingCart""
                               asp-route-id=""");
#nullable restore
#line 39 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                        Write(item.Movie.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\n                                <i class=\"bi bi-cart-plus\"></i>\n                            </a> -->\n\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c70544df6a64a1b68f74f7870accf594f3aea89435", async() => {
                WriteLiteral("\n                                <i class=\"bi bi-x-circle\"></i>\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                                 WriteLiteral(item.Movie.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </td>\n                    </tr>\n");
#nullable restore
#line 49 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\n            <tfoot>\n                <tr>\n                    <td colspan=\"2\"></td>\n                    <td><b>Total:</b></td>\n                    <td>\n                        ৳");
#nullable restore
#line 56 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                    Write(Model.ShoppingCartTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--.ToString(\"c\")-->\n                    </td>\n                    <td></td>\n                </tr>\n            </tfoot>\n        </table>\n\n        <div class=\"text-right\">\n            <div class=\"btn-group\">\n");
            WriteLiteral("                <!-- <div id=\"paypal-btn\"></div> -->\n\n                <div id=\"checkout-btn\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c70544df6a64a1b68f74f7870accf594f3aea813090", async() => {
                WriteLiteral("\n                        <i class=\"bi bi-cart-check\"></i> Checkout\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <span style=\"padding:15px\"></span>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96c70544df6a64a1b68f74f7870accf594f3aea814712", async() => {
                WriteLiteral("\n                    <i class=\"bi bi-plus-circle\"></i> Add more items\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n\n    </div>\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n    <!--<script src=\"https://www.paypalobjects.com/api/checkout.js\"></script> -->\n\n    <script>\n\n        let _total = ");
#nullable restore
#line 91 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                Write(Html.Raw(Model.ShoppingCartTotal));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        checkout.Button.render({
            //Configure environment
            /*env: 'sandbox',
            client: {
                sandbox: 'AcKRtgL4i68EZ2ZYuYUx3ilihAg2YhL5dtF_m19A8MjBWVOn6ewNS4M_uV8gA3xi98zTcUq38gUHbVFx'
            },

            //Customize button
            locale: 'en_US',
            style: {
                size: 'small',
                color: 'gold',
                shape: 'pill'
            },
            commit: true, 

            //Set up a payment
            payment: function (data, actions) {
                return actions.payment.create({
                    transactions: [{
                        amount: {
                            total: _total,
                            currency: 'USD'
                        }
                    }]
                });
            }, */

            //Execute the payment
            onAuthorize: function (data, actions) {
                return actions.payment.execute().then(function () {
                    var url = '");
#nullable restore
#line 124 "C:\Users\Random Admin\source\repos\ScreenCrate\ScreenCrate\Views\Orders\ShoppingCart.cshtml"
                          Write(Url.Action("CompleteOrder", "Orders", new { }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\n                    window.location.href = url;\n                });\n            }\n\n        }, \'#checkout-btn\')\n    </script>\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
