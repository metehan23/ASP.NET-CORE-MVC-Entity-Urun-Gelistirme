#pragma checksum "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1204f8fd6e831980987c752ee8174f30a15f3c4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_NewProduct), @"mvc.1.0.view", @"/Views/Product/NewProduct.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\_ViewImports.cshtml"
using EntityFrameworkCalismalari.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\_ViewImports.cshtml"
using EntityFrameworkCalismalari.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
using EntityFrameworkCalismalari.MvcWebUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1204f8fd6e831980987c752ee8174f30a15f3c4e", @"/Views/Product/NewProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d9f33e117937a3f4aa700f514638d839963eba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_NewProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewProductVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Product/NewProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
  
    ViewData["Title"] = "NewProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Ürün Ekleme Formu</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1204f8fd6e831980987c752ee8174f30a15f3c4e4880", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label>Ürün Adı</label>
        <input type=""text"" class=""form-control"" name=""ProductName"" id=""txtProductName"" />
    </div>
    <div class=""form-group"">
        <label>Birim Açıklaması</label>
        <input type=""text"" class=""form-control"" name=""QuantityPerUnit"" id=""txtQuantityPerUnit"" />
    </div>
    <div class=""form-group"">
        <label>Fiyat</label>
        <input type=""number"" class=""form-control"" name=""UnitPrice"" id=""txtUnitPrice"" />
    </div>
    <div class=""form-group"">
        <label>Kategorisi</label>
        <select class=""form-control"" id=""ddlCategories"" name=""CategoryId"" />
");
#nullable restore
#line 26 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1204f8fd6e831980987c752ee8174f30a15f3c4e6151", async() => {
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Tedarikçiler</label>\r\n        <select class=\"form-control\" id=\"ddlSuppliers\" name=\"SupplierID\" />\r\n");
#nullable restore
#line 35 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
         foreach (var item in Model.Suppliers)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1204f8fd6e831980987c752ee8174f30a15f3c4e8887", async() => {
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
                                   Write(item.Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\Lenovo\Desktop\MVC_Uygulamalarr\EntityFrameworkCalismalari\EntityFrameworkCalismalari.MvcWebUI\Views\Product\NewProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </select>
    </div>
    <div class=""form-check"">
        <input class=""form-check-input"" type=""checkbox"" value=""Discontinued"" name=""Discontinued"" id=""chkDiscontinued"">
        <label class=""form-check-label"">
            Bitti
        </label>
    </div>
    <div class=""form-group"">
        <input type=""submit"" class=""btn btn-primary"" id=""btnSave"" value=""KAYDET"" />
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewProductVm> Html { get; private set; }
    }
}
#pragma warning restore 1591