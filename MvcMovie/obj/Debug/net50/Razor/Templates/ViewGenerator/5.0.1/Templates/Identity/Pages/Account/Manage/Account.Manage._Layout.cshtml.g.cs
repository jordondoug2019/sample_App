#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage._Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7e6abe20b6e1c9c24e0d3b825c41457ede8d2ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage__Layout), @"mvc.1.0.view", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage._Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7e6abe20b6e1c9c24e0d3b825c41457ede8d2ed", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage._Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage__Layout : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage._Layout.cshtml"
  
    if (ViewData.TryGetValue("ParentLayout", out var parentLayout))
    {
        Layout = (string)parentLayout;
    }
    else
    {
        Layout = "/Areas/Identity/Pages/_Layout.cshtml";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Manage your account</h2>\r\n\r\n<div>\r\n    <h4>Change your account settings</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            <partial name=\"_ManageNav\" />\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            ");
#nullable restore
#line 22 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage._Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage._Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
