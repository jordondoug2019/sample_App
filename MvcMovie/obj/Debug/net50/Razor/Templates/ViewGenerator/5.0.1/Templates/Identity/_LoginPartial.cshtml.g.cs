#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19ce58ccb8de8cadc15761dfe98fa630c0f778d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity__LoginPartial), @"mvc.1.0.view", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19ce58ccb8de8cadc15761dfe98fa630c0f778d0", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity__LoginPartial : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@using Microsoft.AspNetCore.Identity\r\n");
#nullable restore
#line 5 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
  
    if (Model.UserClassNamespace != "Microsoft.AspNetCore.Identity")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@using ");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
     Write(Model.UserClassNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("@inject SignInManager<");
#nullable restore
#line 13 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
                    Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> SignInManager\r\n");
            WriteLiteral("@inject UserManager<");
#nullable restore
#line 14 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
                  Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> UserManager\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<ul class=\"navbar-nav\">\r\n");
            WriteLiteral("@if (SignInManager.IsSignedIn(User))\r\n");
            WriteLiteral("{\r\n");
            WriteLiteral("    <li class=\"nav-item\">\r\n");
            WriteLiteral("        <a id=\"manage\" class=\"nav-link text-dark\" asp-area=\"Identity\" asp-page=\"/Account/Manage/Index\" title=\"Manage\">Hello ");
            WriteLiteral("@UserManager.GetUserName(User)!</a>\r\n");
            WriteLiteral("    </li>\r\n");
            WriteLiteral("    <li class=\"nav-item\">\r\n");
#nullable restore
#line 25 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
      if (Model.IsRazorPagesProject)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <form id=\"logoutForm\" class=\"form-inline\" asp-area=\"Identity\" asp-page=\"/Account/Logout\" asp-route-returnUrl=\"");
            WriteLiteral("@Url.Page(\"/Index\", new { area = \"\" })\">\r\n");
#nullable restore
#line 28 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
      }
      else
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <form id=\"logoutForm\" class=\"form-inline\" asp-area=\"Identity\" asp-page=\"/Account/Logout\" asp-route-returnUrl=\"");
            WriteLiteral("@Url.Action(\"Index\", \"Home\", new { area = \"\" })\">\r\n");
#nullable restore
#line 32 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/_LoginPartial.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button id=\"logout\" type=\"submit\" class=\"nav-link btn btn-link text-dark\">Logout</button>\r\n");
            WriteLiteral("        </form>\r\n");
            WriteLiteral("    </li>\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("else\r\n");
            WriteLiteral("{\r\n");
            WriteLiteral("    <li class=\"nav-item\">\r\n");
            WriteLiteral("        <a class=\"nav-link text-dark\" id=\"register\" asp-area=\"Identity\" asp-page=\"/Account/Register\">Register</a>\r\n");
            WriteLiteral("    </li>\r\n");
            WriteLiteral("    <li class=\"nav-item\">\r\n");
            WriteLiteral("        <a class=\"nav-link text-dark\" id=\"login\" asp-area=\"Identity\" asp-page=\"/Account/Login\">Login</a>\r\n");
            WriteLiteral("    </li>\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("</ul>\r\n");
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
