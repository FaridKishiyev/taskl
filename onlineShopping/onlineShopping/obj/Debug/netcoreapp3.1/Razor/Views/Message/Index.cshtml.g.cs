#pragma checksum "C:\Users\Ferid\Desktop\Code Academy\BackEnd\onlineShopping\onlineShopping\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27bdb5e4ec6b49d12f28fe1bcc24353f3ab55815"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Index), @"mvc.1.0.view", @"/Views/Message/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27bdb5e4ec6b49d12f28fe1bcc24353f3ab55815", @"/Views/Message/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f576a41845d0f29474c76bbfc108f35716f0b2fd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Menu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27bdb5e4ec6b49d12f28fe1bcc24353f3ab558155446", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Document</title>


    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css""
          rel=""stylesheet"" />
    <link rel=""stylesheet""
          href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.2/css/all.min.css"" />
    <link rel=""stylesheet"" href=""assets/css/style.css"" />
    <link rel=""stylesheet"" href=""assets/css/contact.css"">
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27bdb5e4ec6b49d12f28fe1bcc24353f3ab558157001", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "27bdb5e4ec6b49d12f28fe1bcc24353f3ab558157263", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <main>\r\n        <section id=\"contact\">\r\n\r\n            <h1 class=\"section-header\">Contact</h1>\r\n\r\n            <div class=\"contact-wrapper\">\r\n\r\n                <!-- Left contact page -->\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27bdb5e4ec6b49d12f28fe1bcc24353f3ab558158675", async() => {
                    WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <div class=\"col-sm-12\">\r\n                            <input type=\"text\" class=\"form-control\" id=\"name\" placeholder=\"Ad,soyad\" name=\"fullname\"");
                    BeginWriteAttribute("value", " value=\"", 1157, "\"", 1165, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" required>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <div class=""col-sm-12"">
                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""Email"" name=""email""");
                    BeginWriteAttribute("value", " value=\"", 1447, "\"", 1455, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" required>
                        </div>
                    </div>

                    <textarea class=""form-control"" rows=""10"" placeholder=""Mesajınız"" name=""message"" required></textarea>

                    <button class=""btn btn-primary send-button"" id=""submit"" type=""submit"" value=""SEND"">
                        <div class=""alt-send-button"">
                            <i class=""fa fa-paper-plane""></i><span class=""send-text"">SEND</span>
                        </div>

                    </button>

                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                <!-- Left contact page -->

                <div class=""direct-contact-container"">

                    <ul class=""contact-list"">
                        <li class=""list-item""><i class=""fa fa-map-marker fa-2x""><span class=""contact-text place"">City, State</span></i></li>

                        <li class=""list-item""><i class=""fa fa-phone fa-2x""><span class=""contact-text phone""><a href=""tel:1-212-555-5555"" title=""Give me a call"">(212) 555-2368</a></span></i></li>

                        <li class=""list-item""><i class=""fa fa-envelope fa-2x""><span class=""contact-text gmail""><a href=""mailto:#"" title=""Send me an email"">hitmeup@gmail.com</a></span></i></li>

                    </ul>

                    <hr>
                    <ul class=""social-media-list"">
                        <li>
                            <a href=""#"" target=""_blank"" class=""contact-icon"">
                                <i class=""fa-brands fa-linkedin-in"" aria-hidden=""true""></i>
                      ");
                WriteLiteral(@"      </a>
                        </li>
                        <li>
                            <a href=""#"" target=""_blank"" class=""contact-icon"">
                                <i class=""fa-brands fa-instagram"" aria-hidden=""true""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" target=""_blank"" class=""contact-icon"">
                                <i class=""fa-brands fa-twitter"" aria-hidden=""true""></i>
                            </a>
                        </li>
                        <li>
                            <a href=""#"" target=""_blank"" class=""contact-icon"">
                                <i class=""fa-brands fa-facebook-f"" aria-hidden=""true""></i>
                            </a>
                        </li>
                    </ul>
                    <hr>

                    <div class=""copyright"">Bizi burdan izləyin</div>

                </div>

            </div>

        </se");
                WriteLiteral(@"ction>


    </main>
    <footer>
        <div class=""footer-area"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-3"">
                        <h5>Shopping</h5>
                        <ul>
                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4344, "\"", 4351, 0);
                EndWriteAttribute();
                WriteLiteral(">Haqqımızda</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4408, "\"", 4415, 0);
                EndWriteAttribute();
                WriteLiteral(">Qaydalarımız</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4474, "\"", 4481, 0);
                EndWriteAttribute();
                WriteLiteral(">Markalar</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4536, "\"", 4543, 0);
                EndWriteAttribute();
                WriteLiteral(">Məhsul Kataloqu</a></li>\r\n                        </ul>\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <h5>Xüsusi məhsullar</h5>\r\n                        <ul>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4786, "\"", 4793, 0);
                EndWriteAttribute();
                WriteLiteral(">Hədiyyə kartları</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4856, "\"", 4863, 0);
                EndWriteAttribute();
                WriteLiteral(">Xüsusi qablaşdırma</a></li>\r\n                            <li><a");
                BeginWriteAttribute("href", " href=\"", 4928, "\"", 4935, 0);
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
                WriteLiteral("             <h5>Təklifləriniz</h5>\r\n                    <p>Şikayət və təklifləriniz üçün <br> bizə müraciət edə bilərsiz</p>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 6109, "\"", 6116, 0);
                EndWriteAttribute();
                WriteLiteral(@">Müraciət üçün</a>

                </div>
            </div>
        </div>
        </div>
    </footer>
    <!-- JS -->
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/js/style.js""></script>
    <script src=""assets/js/contact.js""></script>
");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591