#pragma checksum "C:\Users\chris\source\repos\Audemus\Audemus\Pages\Contacts\ClientContacts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b18eeded4ce55525f6d82f7b51fd625f91c9bda4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Audemus.Pages.Contacts.Pages_Contacts_ClientContacts), @"mvc.1.0.razor-page", @"/Pages/Contacts/ClientContacts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Contacts/ClientContacts.cshtml", typeof(Audemus.Pages.Contacts.Pages_Contacts_ClientContacts), null)]
namespace Audemus.Pages.Contacts
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b18eeded4ce55525f6d82f7b51fd625f91c9bda4", @"/Pages/Contacts/ClientContacts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fedde4a2bd0378ea03b5b11564160bcb2829e259", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Contacts_ClientContacts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\chris\source\repos\Audemus\Audemus\Pages\Contacts\ClientContacts.cshtml"
  
    ViewData["Title"] = "ClientContacts";

#line default
#line hidden
            BeginContext(108, 30, true);
            WriteLiteral("\r\n<h2>Client Contacts</h2>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(156, 225, true);
                WriteLiteral("\r\n<script>\r\n\r\n    $(function () {\r\n        $.ajax(\"/api/contacts/\",\r\n            { method: \"get\" })\r\n            .then(function (response) {\r\n                console.dir(response);\r\n\r\n            });\r\n    });\r\n\r\n\r\n</script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Audemus.Pages.Contacts.ClientContactsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Audemus.Pages.Contacts.ClientContactsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Audemus.Pages.Contacts.ClientContactsModel>)PageContext?.ViewData;
        public Audemus.Pages.Contacts.ClientContactsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591