#pragma checksum "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23ef778de31c6c594f68b6214ddace1741a3ea4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Basket_IndexCookie), @"mvc.1.0.view", @"/Views/Basket/IndexCookie.cshtml")]
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
#line 2 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\_ViewImports.cshtml"
using onlineShopping.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\_ViewImports.cshtml"
using onlineShopping.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ef778de31c6c594f68b6214ddace1741a3ea4a", @"/Views/Basket/IndexCookie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f576a41845d0f29474c76bbfc108f35716f0b2fd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Basket_IndexCookie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BasketCookie>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/basket.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReduceBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BuyBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/style.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/js/basket.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
  
    double totalPrice = 0;
    double edv = 0;
    double kuryer = 5;
    double checkPrice = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a8742", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Document</title>



    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css""
          rel=""stylesheet"" />
    <link rel=""stylesheet""
          href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23ef778de31c6c594f68b6214ddace1741a3ea4a9566", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "23ef778de31c6c594f68b6214ddace1741a3ea4a10744", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a12628", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23ef778de31c6c594f68b6214ddace1741a3ea4a12926", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <main>\r\n\r\n\r\n        <div class=\"container\">\r\n\r\n            <section id=\"cart\">\r\n\r\n");
#nullable restore
#line 95 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                 foreach (var item in Model.basketProduct )
                {
                    double allPrice = item.price * item.BasketCount;

                    



#line default
#line hidden
#nullable disable
                WriteLiteral("                    <article class=\"product\">\r\n                        <header>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a14722", async() => {
                    WriteLiteral("\r\n                                <img src=\"http://www.astudio.si/preview/blockedwp/wp-content/uploads/2012/08/1.jpg\"");
                    BeginWriteAttribute("alt", " alt=\"", 4467, "\"", 4473, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n");
#nullable restore
#line 106 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                 if (item.basketBuy == true)
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <h3>Aldiz</h3>\r\n");
#nullable restore
#line 109 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                                    <h3>Remove product</h3>\r\n");
#nullable restore
#line 113 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                                                                  WriteLiteral(item.Id);

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
                WriteLiteral("\r\n                        </header>\r\n\r\n                        <div class=\"content\">\r\n\r\n                            <h1>");
#nullable restore
#line 119 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                           Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n\r\n                            ");
#nullable restore
#line 121 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                       Write(item.ProductDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            <div");
                BeginWriteAttribute("title", " title=\"", 5087, "\"", 5095, 0);
                EndWriteAttribute();
                WriteLiteral("  class=\"color yellow\"></div>\r\n");
#nullable restore
#line 124 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                            foreach (var product in Model.products)
                            {
                                if (product.Id == @item.Id )
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div style=\"top: 43px\" class=\"type small\">");
#nullable restore
#line 128 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                                         Write(product.size.SizeValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 129 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            \r\n                        </div>\r\n\r\n                        <footer class=\"content\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a20926", async() => {
                    WriteLiteral("<span class=\"qt-minus\">-</span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                                                   WriteLiteral(item.Id);

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
                WriteLiteral("\r\n                            <span class=\"qt\">");
#nullable restore
#line 136 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                        Write(item.BasketCount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a23859", async() => {
                    WriteLiteral("<span class=\"qt-plus\">+</span>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 137 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                                                WriteLiteral(item.Id);

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
                WriteLiteral("\r\n\r\n                            <h2 class=\"full-price\">\r\n                                ");
#nullable restore
#line 140 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                           Write(allPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" \r\n                            </h2>\r\n\r\n                            <h2 class=\"price\">\r\n                                  ");
#nullable restore
#line 144 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                             Write(item.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("                                \r\n                            </h2>\r\n                        </footer>\r\n                    </article>\r\n");
#nullable restore
#line 148 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n            </section>\r\n\r\n        </div>\r\n\r\n        <div id=\"site-footer\">\r\n            <div class=\"container clearfix\">\r\n");
#nullable restore
#line 158 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                 foreach (var item in Model.basketProduct )
                {
                    double allPrice = item.price * item.BasketCount;
                    totalPrice += allPrice;

                    edv = Math.Floor( totalPrice * 0.18);

                    checkPrice = edv + totalPrice + kuryer;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"left\">\r\n                    <h2 class=\"subtotal\">Məhsullar: <span>");
#nullable restore
#line 168 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                     Write(totalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>$</h2>\r\n                    <h3 class=\"tax\">Ədv (18%): <span>");
#nullable restore
#line 169 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                Write(edv);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>$</h3>\r\n                    <h3 class=\"shipping\">Çatdırılma: <span>");
#nullable restore
#line 170 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                                      Write(kuryer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>$</h3>\r\n                </div>\r\n                  \r\n                <div class=\"right\">\r\n                    <h1 class=\"total\">Total: <span> ");
#nullable restore
#line 174 "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Basket\IndexCookie.cshtml"
                                               Write(checkPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>$</h1>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a29886", async() => {
                    WriteLiteral("Checkout");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                

            </div>
        </div>
    </main>
    <footer>
        <div class=""footer-area"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-3"">
                        <h5>Shopping</h5>
                        <ul>
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7703, "\"", 7710, 0);
                EndWriteAttribute();
                WriteLiteral(">Haqqımızda</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7767, "\"", 7774, 0);
                EndWriteAttribute();
                WriteLiteral(">Qaydalarımız</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7833, "\"", 7840, 0);
                EndWriteAttribute();
                WriteLiteral(">Markalar</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 7895, "\"", 7902, 0);
                EndWriteAttribute();
                WriteLiteral(">Məhsul Kataloqu</a></li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <h5>Xüsusi məhsullar</h5>\r\n                        <ul>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8145, "\"", 8152, 0);
                EndWriteAttribute();
                WriteLiteral(">Hədiyyə kartları</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8215, "\"", 8222, 0);
                EndWriteAttribute();
                WriteLiteral(">Xüsusi qablaşdırma</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 8287, "\"", 8294, 0);
                EndWriteAttribute();
                WriteLiteral(@">Özəl endirimlər</a></li>
                        </ul>
                    </div>
                    <div class=""col-3"">
                        <h5>Sosyal şəbəkə</h5>
                        <ul class=""social-icons"">
                            <a href=""#""><div class=""icon-box"">
                            <li><i class=""fab fa-facebook"" aria-hidden=""true""></i></li>
                    </div></a>
                    <a href=""#""><div class=""icon-box""><li><i class=""fab fa-twitter"" aria-hidden=""true""></i></li></div></a>
                    <a href=""#""><div class=""icon-box""><li><i class=""fab fa-google-plus-g"" aria-hidden=""true""></i></li></div></a>
                    <a href=""#""><div class=""icon-box""><li><i class=""fab fa-linkedin"" aria-hidden=""true""></i></li></div></a>
                    <a href=""#""><div class=""icon-box""><li><i class=""fab fa-instagram"" aria-hidden=""true""></i></li></div></a>
                    </ul>
                </div>
                <div class=""col-3 send-message"">
       ");
                WriteLiteral("             <h5>Təklifləriniz</h5>\r\n                    <p>Şikayət və təklifləriniz üçün bizə müraciət edə bilərsiz</p>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 9463, "\"", 9470, 0);
                EndWriteAttribute();
                WriteLiteral(">Müraciət üçün</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        </div>\r\n    </footer>\r\n    <!-- JS -->\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a35067", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23ef778de31c6c594f68b6214ddace1741a3ea4a36168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BasketCookie> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591