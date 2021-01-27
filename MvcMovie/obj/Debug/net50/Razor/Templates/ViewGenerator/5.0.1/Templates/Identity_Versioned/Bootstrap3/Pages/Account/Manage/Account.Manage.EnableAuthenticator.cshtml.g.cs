#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbdb042874ab7094ded17f9c7b33b0b95f227cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_EnableAuthenticator), @"mvc.1.0.razor-page", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbdb042874ab7094ded17f9c7b33b0b95f227cfd", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_EnableAuthenticator : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml"
  
    ViewData["Title"] = "Configure authenticator app";
    ViewData["ActivePage"] = ManageNavPages.TwoFactorAuthentication;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<partial name=\"_StatusMessage\" for=\"StatusMessage\" />\r\n<h4>");
#nullable restore
#line 9 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<div>
    <p>To use an authenticator app go through the following steps:</p>
    <ol class=""list"">
        <li>
            <p>
                Download a two-factor authenticator app like Microsoft Authenticator for
                <a href=""https://go.microsoft.com/fwlink/?Linkid=825072"">Android</a> and
                <a href=""https://go.microsoft.com/fwlink/?Linkid=825073"">iOS</a> or
                Google Authenticator for
                <a href=""https://play.google.com/store/apps/details?id=com.google.android.apps.authenticator2&amp;hl=en"">Android</a> and
                <a href=""https://itunes.apple.com/us/app/google-authenticator/id388497605?mt=8"">iOS</a>.
            </p>
        </li>
        <li>
            <p>Scan the QR Code or enter this key <kbd>");
#nullable restore
#line 24 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml"
                                                  Write(Model.SharedKey);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</kbd> into your two factor authenticator app. Spaces and casing do not matter.</p>
            <div class=""alert alert-info"">Learn how to <a href=""https://go.microsoft.com/fwlink/?Linkid=852423"">enable QR code generation</a>.</div>
            <div id=""qrCode""></div>
            <div id=""qrCodeData"" data-url=""");
#nullable restore
#line 27 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.EnableAuthenticator.cshtml"
                                      Write(Html.Raw(Model.AuthenticatorUri));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""></div>
        </li>
        <li>
            <p>
                Once you have scanned the QR code or input the key above, your two factor authentication app will provide you
                with a unique code. Enter the code in the confirmation box below.
            </p>
            <div class=""row"">
                <div class=""col-md-6"">
                    <form method=""post"">
                        <div class=""form-group"">
                            <label asp-for=""Input.Code"" class=""control-label"">Verification Code</label>
                            <input asp-for=""Input.Code"" class=""form-control"" autocomplete=""off"" />
                            <span asp-validation-for=""Input.Code"" class=""text-danger""></span>
                        </div>
                        <button type=""submit"" class=""btn btn-default"">Verify</button>
                        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                    </form>
                </div>
            <");
            WriteLiteral("/div>\r\n        </li>\r\n    </ol>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <partial name=\"_ValidationScriptsPartial\" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnableAuthenticatorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EnableAuthenticatorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EnableAuthenticatorModel>)PageContext?.ViewData;
        public EnableAuthenticatorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
