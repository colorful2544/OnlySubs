#pragma checksum "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41f4ae0e239e1a0f9db8ab0fc53a6f555b1d1139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41f4ae0e239e1a0f9db8ab0fc53a6f555b1d1139", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566d5720371474950e311617fef407292044e918", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PostsResponse>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <div class=\"d-flex flex-row-reverse\" style=\"margin-top: 100px;\">\r\n        <a href=\"/post/create\" class=\"btn btn-primary\">Create</a>\r\n    </div>\r\n");
#nullable restore
#line 10 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2>ดูเหมือนว่าคุณจะยังไม่ได้ติดตามใครนะ ลองติดตามคนที่คุณชอบดูไหม ?</h2>\r\n");
#nullable restore
#line 13 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"d-flex justify-content-center\">\r\n                <div class=\"posts mt-5\">\r\n                    <header class=\"post-header\">\r\n                        <div>\r\n                            <img class=\"img-profile\"");
            BeginWriteAttribute("src", " src=\"", 658, "\"", 718, 1);
#nullable restore
#line 22 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
WriteAttributeValue("", 664, Url.Content($"~/wwwroot/images/{@item.ProfileImage}"), 664, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"header-text\">\r\n                            <a class=\"username-link\"");
            BeginWriteAttribute("href", " href=\"", 857, "\"", 887, 2);
            WriteAttributeValue("", 864, "/account/", 864, 9, true);
#nullable restore
#line 25 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
WriteAttributeValue("", 873, item.Username, 873, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <h4 class=\"username\">");
#nullable restore
#line 26 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
                                                Write(item.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                            </a>\r\n                            <span>");
#nullable restore
#line 28 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
                             Write(item.Created.ToString("dddd, dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </header>\r\n                    <div class=\"content-img\">\r\n");
#nullable restore
#line 32 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
                         if (string.IsNullOrEmpty(item.ImageName))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"content-text\">\r\n                                <div>\r\n                                    <h4>If you want to wisit this post</h4>\r\n                                    <p>");
#nullable restore
#line 37 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
                                  Write(item.Price.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" $ for this post</p>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1609, 2);
            WriteAttributeValue("", 1591, "/post/", 1591, 6, true);
#nullable restore
#line 38 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
WriteAttributeValue("", 1597, item.PostId, 1597, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary mt-4\">Buy now</a>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 41 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1843, "\"", 1868, 2);
            WriteAttributeValue("", 1850, "/post/", 1850, 6, true);
#nullable restore
#line 44 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
WriteAttributeValue("", 1856, item.PostId, 1856, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1908, "\"", 1965, 1);
#nullable restore
#line 45 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
WriteAttributeValue("", 1914, Url.Content($"~/wwwroot/images/{@item.ImageName}"), 1914, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </a>   \r\n");
#nullable restore
#line 47 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Home\Index.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PostsResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
