#pragma checksum "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1360c95d9c99825e8ce50db30731ab12deef33f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Search), @"mvc.1.0.view", @"/Views/Account/Search.cshtml")]
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
#line 1 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\_ViewImports.cshtml"
using OnlySubs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\_ViewImports.cshtml"
using OnlySubs.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\_ViewImports.cshtml"
using OnlySubs.ViewModels.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\_ViewImports.cshtml"
using OnlySubs.ViewModels.Responses;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1360c95d9c99825e8ce50db30731ab12deef33f8", @"/Views/Account/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566d5720371474950e311617fef407292044e918", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SearchResponse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" style=\"width: 500px; margin-top: 120px;\">\r\n");
#nullable restore
#line 6 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
     if (Model != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"account-contanier mt-5\">\r\n                <div class=\"account-img\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 342, "\"", 399, 1);
#nullable restore
#line 12 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
WriteAttributeValue("", 348, Url.Content($"~/wwwroot/images/{@item.ImageName}"), 348, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"account-detail\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 495, "\"", 525, 2);
            WriteAttributeValue("", 502, "/account/", 502, 9, true);
#nullable restore
#line 15 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
WriteAttributeValue("", 511, item.Username, 511, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color: black; text-decoration: none;\">\r\n                        <h3>");
#nullable restore
#line 16 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
                       Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </a>\r\n                    <div class=\"account-detail-follow\">\r\n                        <span class=\"account-detail-follower\">");
#nullable restore
#line 19 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
                                                         Write(item.Follower);

#line default
#line hidden
#nullable disable
            WriteLiteral(" follower</span>\r\n                        <span class=\"account-detail-followimg\">");
#nullable restore
#line 20 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
                                                          Write(item.Following);

#line default
#line hidden
#nullable disable
            WriteLiteral(" following</span>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"no-posts text-center\" style=\"margin-top: 120px;\">Account not found :(</h1>\r\n");
#nullable restore
#line 29 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SearchResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
