#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e9b5184bfd7e8a23a4f40904bcef8016a4fcb77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage_Disable2fa_cs), @"mvc.1.0.view", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e9b5184bfd7e8a23a4f40904bcef8016a4fcb77", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/_ViewImports.cshtml")]
    public class Templates_ControllerGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage_Disable2fa_cs : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\n");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
  
    var namespaceSet = new HashSet<string>(
        new string[]
        {
            "Microsoft.AspNetCore.Identity",
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.RazorPages",
            "Microsoft.Extensions.Logging",
        });

    var thisNamespace = $"{Model.Namespace}.Areas.Identity.Pages.Account.Manage";
    if (!string.IsNullOrEmpty(Model.UserClassNamespace) && thisNamespace != Model.UserClassNamespace)
    {
        namespaceSet.Add(Model.UserClassNamespace);
    }
    foreach (var name in namespaceSet.OrderBy(n => n))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("using ");
#nullable restore
#line 25 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 26 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 29 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
     Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class Disable2faModel : PageModel\r\n    {\r\n        private readonly UserManager<");
#nullable restore
#line 33 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
                                 Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _userManager;\r\n        private readonly ILogger<Disable2faModel> _logger;\r\n\r\n        public Disable2faModel(\r\n            UserManager<");
#nullable restore
#line 37 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.Disable2fa.cs.cshtml"
                    Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> userManager,
            ILogger<Disable2faModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            if (!await _userManager.GetTwoFactorEnabledAsync(user))
            {
                throw new InvalidOperationException($""Cannot disable 2FA for user with ID '{_userManager.GetUserId(User)}' as it's not currently enabled."");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFoun");
            WriteLiteral(@"d($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            var disable2faResult = await _userManager.SetTwoFactorEnabledAsync(user, false);
            if (!disable2faResult.Succeeded)
            {
                throw new InvalidOperationException($""Unexpected error occurred disabling 2FA for user with ID '{_userManager.GetUserId(User)}'."");
            }

            _logger.LogInformation(""User with ID '{UserId}' has disabled 2fa."", _userManager.GetUserId(User));
            StatusMessage = ""2fa has been disabled. You can reenable 2fa when you setup an authenticator app"";
            return RedirectToPage(""./TwoFactorAuthentication"");
        }
    }
}");
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
