#pragma checksum "C:\Users\rmcca\OneDrive\Desktop\Basic_C#_Programs\Basic-C-Projects\StudentsApp\StudentsApp\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ce21bff577a464d9da8b040e8d01275a233bf95"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(StudentsApp.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
namespace StudentsApp.Pages
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
#line 1 "C:\Users\rmcca\OneDrive\Desktop\Basic_C#_Programs\Basic-C-Projects\StudentsApp\StudentsApp\Pages\_ViewImports.cshtml"
using StudentsApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ce21bff577a464d9da8b040e8d01275a233bf95", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0927cc580acc5a1be9f14a5631866c686bf4b813", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\rmcca\OneDrive\Desktop\Basic_C#_Programs\Basic-C-Projects\StudentsApp\StudentsApp\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";
    ViewData["PageInfo"] = "Page Information";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\rmcca\OneDrive\Desktop\Basic_C#_Programs\Basic-C-Projects\StudentsApp\StudentsApp\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h2>");
#nullable restore
#line 8 "C:\Users\rmcca\OneDrive\Desktop\Basic_C#_Programs\Basic-C-Projects\StudentsApp\StudentsApp\Pages\Privacy.cshtml"
Write(ViewData["PageInfo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<p>This page is under construction as of ");
#nullable restore
#line 10 "C:\Users\rmcca\OneDrive\Desktop\Basic_C#_Programs\Basic-C-Projects\StudentsApp\StudentsApp\Pages\Privacy.cshtml"
                                    Write(ViewData["TimeStamp"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591