#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "707b141c204b686efffbf3eef7ea787f076f7e5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage_ExternalLogins), @"mvc.1.0.razor-page", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707b141c204b686efffbf3eef7ea787f076f7e5a", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage_ExternalLogins : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
  
    ViewData["Title"] = "Manage your external logins";
    ViewData["ActivePage"] = ManageNavPages.ExternalLogins;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<partial name=\"_StatusMessage\" for=\"StatusMessage\" />\r\n");
#nullable restore
#line 9 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
 if (Model.CurrentLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Registered Logins</h4>\r\n    <table class=\"table\">\r\n        <tbody>\r\n");
#nullable restore
#line 14 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
             foreach (var login in Model.CurrentLogins)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td");
            BeginWriteAttribute("id", " id=\"", 450, "\"", 497, 1);
#nullable restore
#line 17 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue("", 455, $"login-provider-{login.LoginProvider}", 455, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                                                                   Write(login.ProviderDisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 19 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                         if (Model.ShowRemoveButton)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <form");
            BeginWriteAttribute("id", " id=\"", 672, "\"", 717, 1);
#nullable restore
#line 21 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue("", 677, $"remove-login-{login.LoginProvider}", 677, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" asp-page-handler=\"RemoveLogin\" method=\"post\">\r\n                                <div>\r\n                                    <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 847, "\"", 877, 1);
#nullable restore
#line 23 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue("", 857, login.LoginProvider, 857, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"LoginProvider\" type=\"hidden\" />\r\n                                    <input");
            BeginWriteAttribute("asp-for", " asp-for=\"", 960, "\"", 988, 1);
#nullable restore
#line 24 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue("", 970, login.ProviderKey, 970, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"ProviderKey\" type=\"hidden\" />\r\n                                    <button type=\"submit\" class=\"btn btn-primary\"");
            BeginWriteAttribute("title", " title=\"", 1108, "\"", 1178, 7);
            WriteAttributeValue("", 1116, "Remove", 1116, 6, true);
            WriteAttributeValue(" ", 1122, "this", 1123, 5, true);
#nullable restore
#line 25 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue(" ", 1127, login.ProviderDisplayName, 1128, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1154, "login", 1155, 6, true);
            WriteAttributeValue(" ", 1160, "from", 1161, 5, true);
            WriteAttributeValue(" ", 1165, "your", 1166, 5, true);
            WriteAttributeValue(" ", 1170, "account", 1171, 8, true);
            EndWriteAttribute();
            WriteLiteral(">Remove</button>\r\n                                </div>\r\n                            </form>\r\n");
#nullable restore
#line 28 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            WriteLiteral(" &nbsp;\r\n");
#nullable restore
#line 32 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 35 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 38 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
 if (Model.OtherLogins?.Count > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Add another service to log in.</h4>\r\n    <hr />\r\n    <form id=\"link-login-form\" asp-page-handler=\"LinkLogin\" method=\"post\" class=\"form-horizontal\">\r\n        <div id=\"socialLoginList\">\r\n            <p>\r\n");
#nullable restore
#line 46 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                 foreach (var provider in Model.OtherLogins)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("id", " id=\"", 1881, "\"", 1925, 1);
#nullable restore
#line 48 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue("", 1886, $"link-login-button-{provider.Name}", 1886, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"submit\" class=\"btn btn-primary\" name=\"provider\"");
            BeginWriteAttribute("value", " value=\"", 1980, "\"", 2002, 1);
#nullable restore
#line 48 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue("", 1988, provider.Name, 1988, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 2003, "\"", 2058, 6);
            WriteAttributeValue("", 2011, "Log", 2011, 3, true);
            WriteAttributeValue(" ", 2014, "in", 2015, 3, true);
            WriteAttributeValue(" ", 2017, "using", 2018, 6, true);
            WriteAttributeValue(" ", 2023, "your", 2024, 5, true);
#nullable restore
#line 48 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
WriteAttributeValue(" ", 2028, provider.DisplayName, 2029, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2050, "account", 2051, 8, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 48 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                                                                                                                                                                                                         Write(provider.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 49 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </div>\r\n    </form>\r\n");
#nullable restore
#line 53 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.ExternalLogins.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExternalLoginsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ExternalLoginsModel>)PageContext?.ViewData;
        public ExternalLoginsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
