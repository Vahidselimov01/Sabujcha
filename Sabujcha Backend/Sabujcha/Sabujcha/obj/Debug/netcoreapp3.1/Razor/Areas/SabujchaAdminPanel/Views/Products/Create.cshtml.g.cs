#pragma checksum "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Areas\SabujchaAdminPanel\Views\Products\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cabee320b7036624ed2039b4e8786140478e4078"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_SabujchaAdminPanel_Views_Products_Create), @"mvc.1.0.view", @"/Areas/SabujchaAdminPanel/Views/Products/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cabee320b7036624ed2039b4e8786140478e4078", @"/Areas/SabujchaAdminPanel/Views/Products/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/SabujchaAdminPanel/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_SabujchaAdminPanel_Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sabujcha.Models.Products>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Areas\SabujchaAdminPanel\Views\Products\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Create</h4>

<hr />
<style>
    .form-control, .dataTables_wrapper select {
        border: 1px solid #f3f3f3;
        font-weight: 200;
        display: inline-block;
        width: 200px;
    }

        </style>

<div class=""row"">
    <div class=""col-md-4"">
        <form enctype=""multipart/form-data"" asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label"">Name</label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger"">Description</span>
            </div>
            <div class=""f");
            WriteLiteral(@"orm-group"">
                <label asp-for=""ImageUlr"" class=""control-label""></label>
                <input asp-for=""ImageUlr"" class=""form-control"" />
                <span asp-validation-for=""ImageUlr"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OldPrice"" class=""control-label""></label>
                <input asp-for=""OldPrice"" class=""form-control"" />
                <span asp-validation-for=""OldPrice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NewPrice"" class=""control-label""></label>
                <input asp-for=""NewPrice"" class=""form-control"" />
                <span asp-validation-for=""NewPrice"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Rate"" class=""control-label""></label>
                <input asp-for=""Rate"" class=""form-control"" />
                <span asp-validation-f");
            WriteLiteral(@"or=""Rate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\Asus\Desktop\Sabujcha\Sabujcha Backend\Sabujcha\Sabujcha\Areas\SabujchaAdminPanel\Views\Products\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("<script type=\"text/javascript\">\r\n    $(\".custom-file-input\").on(\"change\",function(){\r\n\r\n        var FileName=$(this).val().split(\"\\\\\").pop();\r\n        $(this).siblings(\".custom-file-label\").addClass(\"selected\").html(FileName);\r\n    });\r\n    \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sabujcha.Models.Products> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591