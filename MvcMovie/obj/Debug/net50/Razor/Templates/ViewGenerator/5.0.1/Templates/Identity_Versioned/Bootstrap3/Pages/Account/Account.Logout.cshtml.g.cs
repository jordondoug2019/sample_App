#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e7869360be27d475d2545976da30c2edc10de2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Account_Logout), @"mvc.1.0.razor-page", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e7869360be27d475d2545976da30c2edc10de2", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Account_Logout : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml"
  
    ViewData["Title"] = "Log out";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h1>");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 9 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml"
      
        if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <form class=\"form-inline\" asp-area=\"Identity\" asp-page=\"/Account/Logout\"");
            BeginWriteAttribute("asp-route-returnUrl", " asp-route-returnUrl=\"", 262, "\"", 317, 1);
#nullable restore
#line 12 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml"
WriteAttributeValue("", 284, Url.Page("/", new { area = "" }), 284, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" method=\"post\">\r\n                <button type=\"submit\" class=\"nav-link btn btn-link text-dark\">Click here to Logout</button>\r\n            </form>\r\n");
#nullable restore
#line 15 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>You have successfully logged out of the application.</p>\r\n");
#nullable restore
#line 19 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.Logout.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</header>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LogoutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<LogoutModel>)PageContext?.ViewData;
        public LogoutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
