#pragma checksum "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ebcef39034160daadad06420469126d71971092"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
#line 1 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ebcef39034160daadad06420469126d71971092", @"/Views/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac4c66d93eeacae2cebb532dec37149efba1b780", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5>Orders</h5>\r\n<hr />\r\n");
#nullable restore
#line 7 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
 if (Model.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
     foreach (var order in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card border-success"">
            <div class=""row border-0"">
                <div class=""col-md-3 col-sm-12"">

                    <div class=""card"">
                        <div class=""card-header"">
                            Order Info
                        </div>
                        <div class=""card-body"">
                            <p class=""card-text"">Order No :  ");
#nullable restore
#line 20 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                        Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p class=\"card-text\">Order Date :  ");
#nullable restore
#line 21 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                          Write(order.CreatedOn.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 22 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                             if (order.OrderStatus == OrderStatus.Created)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text alert-info\">Status :  ");
#nullable restore
#line 24 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                     Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 25 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }
                            else if (order.OrderStatus == OrderStatus.Canceled)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text alert-danger\">Status :  ");
#nullable restore
#line 28 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                       Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 29 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }
                            else if (order.OrderStatus == OrderStatus.Updated)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text alert-success\">Status :  ");
#nullable restore
#line 32 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                        Write(order.OrderStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 33 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                             if (order.DeliveryStatus == Delivery.OnTheWay)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text alert-info\">Delivery Status :  ");
#nullable restore
#line 37 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                              Write(order.DeliveryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 38 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }
                            else if (order.DeliveryStatus == Delivery.Delivered)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text alert-success\">Delivery Status :  ");
#nullable restore
#line 41 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                                 Write(order.DeliveryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 42 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }
                            else if (order.DeliveryStatus == Delivery.Canceled)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"card-text alert-danger\">Delivery Status :  ");
#nullable restore
#line 45 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                                Write(order.DeliveryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 46 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 49 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                             if (User.IsInRole("admin"))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ebcef39034160daadad06420469126d7197109211723", async() => {
                WriteLiteral("\r\n                                    <i class=\"fa fa-edit fa-fw\"></i> Update\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                                              WriteLiteral(order.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-12"">

                    <div class=""card"">
                        <div class=""card-header"">
                            Payment Options
                        </div>
                        <div class=""card-body"">
                            <p class=""card-text"">Method:  ");
#nullable restore
#line 65 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                     Write(order.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p class=\"card-text\"> Status :  ");
#nullable restore
#line 66 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                       Write(order.PaymentMethodStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p class=\"card-text\"> Type :  ");
#nullable restore
#line 67 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                     Write(order.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            Billing Address
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">");
#nullable restore
#line 77 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                              Write(order.BillingAddress.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                Address1:  ");
#nullable restore
#line 79 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                      Write(order.BillingAddress.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; City:  ");
#nullable restore
#line 80 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                         Write(order.BillingAddress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; State:   ");
#nullable restore
#line 81 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                           Write(order.BillingAddress.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; Country:     ");
#nullable restore
#line 82 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                               Write(order.BillingAddress.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; PostalCode:   ");
#nullable restore
#line 83 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                Write(order.BillingAddress.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; Phone:  ");
#nullable restore
#line 84 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                          Write(order.BillingAddress.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; Email:    ");
#nullable restore
#line 85 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                            Write(order.BillingAddress.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-3 col-sm-12"">
                    <div class=""card"">
                        <div class=""card-header"">
                            Shipping Address
                        </div>
                        <div class=""card-body"">
                            <h5 class=""card-title"">");
#nullable restore
#line 96 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                              Write(order.ShippingAddress.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                Address1:  ");
#nullable restore
#line 98 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                      Write(order.ShippingAddress.Address1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; City:  ");
#nullable restore
#line 99 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                         Write(order.ShippingAddress.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; State:   ");
#nullable restore
#line 100 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                           Write(order.ShippingAddress.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; Country:     ");
#nullable restore
#line 101 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                               Write(order.ShippingAddress.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; PostalCode:   ");
#nullable restore
#line 102 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                                Write(order.ShippingAddress.PostalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; Phone:  ");
#nullable restore
#line 103 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                          Write(order.ShippingAddress.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                &nbsp; Email:    ");
#nullable restore
#line 104 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                            Write(order.ShippingAddress.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <hr />
            <div class=""row"">
                <div class=""col-md-8"">
                    <div class=""text-left"">
                        <h5>Items</h5>
                    </div>

");
#nullable restore
#line 117 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                     if (order.OrderItems.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <table class=""table table-striped table-bordered table-sm"" style=""overflow:scroll;"">
                            <thead>
                                <tr>
                                    <th></th>
                                    <th>Product Name</th>
                                    <th>Price</th>
                                    <th>Quantity</th>
                                    <th>Total</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 131 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                 foreach (var i in order.OrderItems)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ebcef39034160daadad06420469126d7197109223566", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6564, "~/img/", 6564, 6, true);
#nullable restore
#line 135 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
AddHtmlAttributeValue("", 6570, i.Product.ImageUrl, 6570, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>");
#nullable restore
#line 137 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                       Write(i.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 138 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                       Write(i.Product.Price.Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 139 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                       Write(i.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 140 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                        Write((i.Quantity * i.Product.Price).Value.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>\r\n                                    </tr>\r\n");
#nullable restore
#line 143 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </tbody>\r\n\r\n                        </table> ");
#nullable restore
#line 146 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                 }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"alert alert-warning\">\r\n                            No Product in Cart!\r\n                        </div>");
#nullable restore
#line 151 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                              }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div class=\"col-md-4\">\r\n\r\n");
#nullable restore
#line 155 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                     if (order.OrderItems.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""text-left"">
                            <h5>Payment Summary</h5>
                        </div>
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <th>Cart Total</th>
                                    <td>");
#nullable restore
#line 164 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                   Write(order.Amount.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                </tr>
                                <tr>
                                    <th>Shipping</th>
                                    <td>Free</td>
                                </tr>
                                <tr>
                                    <th>Order Total</th>
                                    <td>");
#nullable restore
#line 172 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                                   Write(order.Amount.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n                            </tbody>\r\n                        </table>\r\n");
#nullable restore
#line 176 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n            </div>\r\n        </div>\r\n        <hr />\r\n");
#nullable restore
#line 182 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 182 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning\">\r\n        No order placed yet!\r\n    </div>\r\n");
#nullable restore
#line 189 "C:\Users\dalwa\Desktop\GrossaryApp\ShopApp.WebUI\Views\Order\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
