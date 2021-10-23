#pragma checksum "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4dcfe55542b6bae6749a95b64b069bed3a41ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4dcfe55542b6bae6749a95b64b069bed3a41ca7", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"566d5720371474950e311617fef407292044e918", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserProfileResponse>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
  
    ViewData["Title"] = User.Identity.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container-md\">\r\n");
#nullable restore
#line 7 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
     if (ViewData["ErrorMessage"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"no-posts text-center\" style=\"margin-top: 120px;\">Account not found :(</h1>\r\n");
#nullable restore
#line 10 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex justify-content-center\" style=\"margin-top: 100px;\">\r\n            <div class=\"profile mt-5\">\r\n                <div class=\"profile-header\">\r\n                    <div class=\"profile-img\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 521, "\"", 579, 1);
#nullable restore
#line 17 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
WriteAttributeValue("", 527, Url.Content($"~/wwwroot/images/{@Model.ImageName}"), 527, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"profile-detail\">\r\n                        <div class=\"profile-detail-header\">\r\n                            <h2 class=\"profile-username\">");
#nullable restore
#line 21 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                                    Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dcfe55542b6bae6749a95b64b069bed3a41ca75773", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 23 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                 if (User.Identity.Name != Model.Username)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                     if (ViewBag.IsFollow)
                                    {   

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button type=\"submit\" class=\"btn btn-link\">Unfollow</button>\r\n");
#nullable restore
#line 28 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <button type=\"submit\" class=\"btn btn-link\">follow</button>\r\n");
#nullable restore
#line 32 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                     
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 843, "/account/follow/", 843, 16, true);
#nullable restore
#line 22 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
AddHtmlAttributeValue("", 859, Model.Username, 859, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                        <ul class=\"profile-resource mt-3\">\r\n                            <li>Krama ");
#nullable restore
#line 38 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                 Write(Model.Krama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>follower ");
#nullable restore
#line 39 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                    Write(Model.Follower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                            <li>following ");
#nullable restore
#line 40 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                     Write(Model.Following);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <div class=\"profile-description mt-3\">\r\n                            <p>");
#nullable restore
#line 43 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>

                <div class=""row border-top mt-5 justify-content-center mb-3"">
                    <div class=""col-1 text-center border-top normalFont border-3 border-secondary"">
                        Post
                    </div>
                </div>

                <div class=""profile-posts"">
");
#nullable restore
#line 55 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                     if (Model.PostsImage != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                         foreach (var item in Model.PostsImage)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                             if (item.ImageName != string.Empty)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profile-posts-item\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2730, "\"", 2755, 2);
            WriteAttributeValue("", 2737, "/post/", 2737, 6, true);
#nullable restore
#line 62 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
WriteAttributeValue("", 2743, item.PostId, 2743, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <img");
            BeginWriteAttribute("src", " src=\"", 2803, "\"", 2860, 1);
#nullable restore
#line 63 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
WriteAttributeValue("", 2809, Url.Content($"~/wwwroot/images/{@item.ImageName}"), 2809, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 66 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profile-posts-item-buy\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4dcfe55542b6bae6749a95b64b069bed3a41ca713290", async() => {
                WriteLiteral("\r\n                                        <h3> ");
#nullable restore
#line 71 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                                        Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" $</h3>\r\n                                        <p>for visit this post</p>\r\n                                        <button class=\"btn btn-primary mt-3\">Buy now</button>\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3162, "/post/buy/", 3162, 10, true);
#nullable restore
#line 70 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
AddHtmlAttributeValue("", 3172, item.PostId, 3172, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n");
#nullable restore
#line 76 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                         
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h1 style=\"margin-top: 100px;\">ไม่เจอ</h1>\r\n");
#nullable restore
#line 82 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 86 "C:\Users\mintc\Documents\GitHub\OnlySubs\Views\Account\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserProfileResponse> Html { get; private set; }
    }
}
#pragma warning restore 1591
