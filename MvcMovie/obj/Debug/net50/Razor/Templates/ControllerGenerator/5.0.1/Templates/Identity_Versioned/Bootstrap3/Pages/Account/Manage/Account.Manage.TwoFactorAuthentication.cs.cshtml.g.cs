#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a8401a13b6edbd45b83e638b7595b0603572f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_TwoFactorAuthentication_cs), @"mvc.1.0.view", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a8401a13b6edbd45b83e638b7595b0603572f39", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ControllerGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_TwoFactorAuthentication_cs : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\n");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
  
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
#line 25 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 26 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 29 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
     Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class TwoFactorAuthenticationModel : PageModel\r\n    {\r\n        private const string AuthenicatorUriFormat = \"otpauth://totp/{0}:{1}?secret={2}&issuer={0}\";\r\n\r\n        private readonly UserManager<");
#nullable restore
#line 35 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
                                 Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _userManager;\r\n        private readonly SignInManager<");
#nullable restore
#line 36 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
                                   Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _signInManager;\r\n        private readonly ILogger<TwoFactorAuthenticationModel> _logger;\r\n\r\n        public TwoFactorAuthenticationModel(\r\n            UserManager<");
#nullable restore
#line 40 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
                    Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> userManager,\r\n            SignInManager<");
#nullable restore
#line 41 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.TwoFactorAuthentication.cs.cshtml"
                      Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> signInManager,
            ILogger<TwoFactorAuthenticationModel> logger)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public bool HasAuthenticator { get; set; }

        public int RecoveryCodesLeft { get; set; }

        [BindProperty]
        public bool Is2faEnabled { get; set; }

        public bool IsMachineRemembered { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            HasAuthenticator = await _userManager.GetAuthenticatorKeyAsync(user) != null;
            Is2faEnabled = await _userManager.GetTwoFactorEnabledAsync(user);
            IsMachineRemembered = awa");
            WriteLiteral(@"it _signInManager.IsTwoFactorClientRememberedAsync(user);
            RecoveryCodesLeft = await _userManager.CountRecoveryCodesAsync(user);

            return Page();
        }

        public async Task<IActionResult> OnPost()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            await _signInManager.ForgetTwoFactorClientAsync();
            StatusMessage = ""The current browser has been forgotten. When you login again from this browser you will be prompted for your 2fa code."";
            return RedirectToPage();
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
