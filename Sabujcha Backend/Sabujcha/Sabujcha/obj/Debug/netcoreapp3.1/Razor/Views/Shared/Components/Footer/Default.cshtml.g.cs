#pragma checksum "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d28d8aceb1dfcd565890050337d447e631f91a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\_ViewImports.cshtml"
using Sabujcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\_ViewImports.cshtml"
using Sabujcha.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
using Sabujcha.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d28d8aceb1dfcd565890050337d447e631f91a5", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71db29b749a2323773083eb1468ed58c915e99bb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FooterVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/icon-img/payment.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<footer class=\"footer-area pt-75 gray-bg-3\">\r\n    <div class=\"footer-top gray-bg-3 pb-35\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                 foreach (FooterTitles ft in Model.FooterTitles)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6 col-sm-6\">\r\n                        <div class=\"footer-widget mb-40\">\r\n                            <div class=\"footer-title mb-25\">\r\n                                <h4>");
#nullable restore
#line 13 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                               Write(ft.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </div>\r\n                            <div class=\"footer-content\">\r\n                                <ul>\r\n                                   \r\n");
#nullable restore
#line 18 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                   foreach (FooterContent fc in Model.FooterContents)
                                    {
                                       

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                        if (ft.Id==fc.TitlesId)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d28d8aceb1dfcd565890050337d447e631f91a56246", async() => {
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                                                                                               Write(fc.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                                    WriteLiteral(fc.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                                                                    WriteLiteral(fc.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                  \r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 30 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Views\Shared\Components\Footer\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <div class=""footer-bottom pb-25 pt-25 gray-bg-2"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <div class=""copyright"">
                        <p class=""copy-text"">
                            © 2023 <strong>Tiens</strong> Made With <i class=""fa fa-heart"" style=""color:red"" aria-hidden=""true""></i> By <a class=""company-name"" href=""https://themeforest.net/user/codecarnival/portfolio"">
                                <strong> CodeCarnival</strong>
                            </a>.
                        </p>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""payment-img f-right"">
                        <a href=""#"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3d28d8aceb1dfcd565890050337d447e631f91a510937", async() => {
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
            WriteLiteral("\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FooterVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
