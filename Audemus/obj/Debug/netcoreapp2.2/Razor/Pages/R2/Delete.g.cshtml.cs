#pragma checksum "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48e77092adc20d78a76d81a8ef68ab509301c333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Audemus.Pages.R2.Pages_R2_Delete), @"mvc.1.0.razor-page", @"/Pages/R2/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/R2/Delete.cshtml", typeof(Audemus.Pages.R2.Pages_R2_Delete), null)]
namespace Audemus.Pages.R2
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\_ViewImports.cshtml"
using Audemus;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48e77092adc20d78a76d81a8ef68ab509301c333", @"/Pages/R2/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedde4a2bd0378ea03b5b11564160bcb2829e259", @"/Pages/_ViewImports.cshtml")]
    public class Pages_R2_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(88, 175, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Contact</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(264, 48, false);
#line 16 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Name));

#line default
#line hidden
            EndContext();
            BeginContext(312, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(374, 44, false);
#line 19 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Name));

#line default
#line hidden
            EndContext();
            BeginContext(418, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(479, 56, false);
#line 22 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.StreetNumber));

#line default
#line hidden
            EndContext();
            BeginContext(535, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(597, 52, false);
#line 25 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.StreetNumber));

#line default
#line hidden
            EndContext();
            BeginContext(649, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(710, 54, false);
#line 28 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.StreetName));

#line default
#line hidden
            EndContext();
            BeginContext(764, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(826, 50, false);
#line 31 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.StreetName));

#line default
#line hidden
            EndContext();
            BeginContext(876, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(937, 56, false);
#line 34 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.CityLocation));

#line default
#line hidden
            EndContext();
            BeginContext(993, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1055, 52, false);
#line 37 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.CityLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1107, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1168, 57, false);
#line 40 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.StateLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1225, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1287, 53, false);
#line 43 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.StateLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1401, 49, false);
#line 46 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1512, 45, false);
#line 49 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Phone));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1618, 49, false);
#line 52 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1667, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1729, 45, false);
#line 55 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1774, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1835, 57, false);
#line 58 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.DateAttempted));

#line default
#line hidden
            EndContext();
            BeginContext(1892, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1954, 53, false);
#line 61 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.DateAttempted));

#line default
#line hidden
            EndContext();
            BeginContext(2007, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2068, 59, false);
#line 64 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact.EmployeeContact));

#line default
#line hidden
            EndContext();
            BeginContext(2127, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2189, 55, false);
#line 67 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Contact.EmployeeContact));

#line default
#line hidden
            EndContext();
            BeginContext(2244, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2282, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e77092adc20d78a76d81a8ef68ab509301c33312280", async() => {
                BeginContext(2302, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2312, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "48e77092adc20d78a76d81a8ef68ab509301c33312673", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 72 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\R2\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Contact.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2356, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2439, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48e77092adc20d78a76d81a8ef68ab509301c33314574", async() => {
                    BeginContext(2461, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2477, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2490, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Audemus.Pages.R2.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Audemus.Pages.R2.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Audemus.Pages.R2.DeleteModel>)PageContext?.ViewData;
        public Audemus.Pages.R2.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
