#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ecfac1b64a6d9327e7c7b479984c9d03a3b5b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Account_ExternalLogin_cs), @"mvc.1.0.view", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ecfac1b64a6d9327e7c7b479984c9d03a3b5b0", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ControllerGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Account_ExternalLogin_cs : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
");
#nullable restore
#line 13 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
  
    var namespaceSet = new HashSet<string>(
        new string[]
        {
            "Microsoft.AspNetCore.Identity",
            "Microsoft.AspNetCore.Identity.UI.Services",
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.RazorPages",
            "Microsoft.AspNetCore.WebUtilities",
            "Microsoft.Extensions.Logging",
        });

    var thisNamespace = $"{Model.Namespace}.Areas.Identity.Pages.Account";
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
#line 32 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 33 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 36 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
     Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    [AllowAnonymous]\r\n    public class ExternalLoginModel : PageModel\r\n    {\r\n        private readonly SignInManager<");
#nullable restore
#line 41 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
                                   Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _signInManager;\r\n        private readonly UserManager<");
#nullable restore
#line 42 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
                                 Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _userManager;\r\n        private readonly IEmailSender _emailSender;\r\n        private readonly ILogger<ExternalLoginModel> _logger;\r\n\r\n        public ExternalLoginModel(\r\n            SignInManager<");
#nullable restore
#line 47 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
                      Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> signInManager,\r\n            UserManager<");
#nullable restore
#line 48 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
                    Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> userManager,
            ILogger<ExternalLoginModel> logger,
            IEmailSender emailSender)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ProviderDisplayName { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public IActionResult OnGetAsync()
        {
            return RedirectToPage(""./Login"");
        }

        public IActionResult OnPost(string provider, string returnUrl = null)
        {
            // Request a redirect to the external login provider.
            var redirectUrl = Url.Page(""./ExternalLogin"", ");
            WriteLiteral(@"pageHandler: ""Callback"", values: new { returnUrl });
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        public async Task<IActionResult> OnGetCallbackAsync(string returnUrl = null, string remoteError = null)
        {
            returnUrl = returnUrl ?? Url.Content(""~/"");
            if (remoteError != null)
            {
                ErrorMessage = $""Error from external provider: {remoteError}"";
                return RedirectToPage(""./Login"", new {ReturnUrl = returnUrl });
            }
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = ""Error loading external login information."";
                return RedirectToPage(""./Login"", new { ReturnUrl = returnUrl });
            }

            // Sign in the user with this external login provider if the user");
            WriteLiteral(@" already has a login.
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor : true);
            if (result.Succeeded)
            {
                _logger.LogInformation(""{Name} logged in with {LoginProvider} provider."", info.Principal.Identity.Name, info.LoginProvider);
                return LocalRedirect(returnUrl);
            }
            if (result.IsLockedOut)
            {
                return RedirectToPage(""./Lockout"");
            }
            else
            {
                // If the user does not have an account, then ask the user to create an account.
                ReturnUrl = returnUrl;
                ProviderDisplayName = info.ProviderDisplayName;
                if (info.Principal.HasClaim(c => c.Type == ClaimTypes.Email))
                {
                    Input = new InputModel
                    {
                        Email = info.Principal.FindFirstValue(Claim");
            WriteLiteral(@"Types.Email)
                    };
                }
                return Page();
            }
        }

        public async Task<IActionResult> OnPostConfirmationAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content(""~/"");
            // Get the information about the user from the external login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();
            if (info == null)
            {
                ErrorMessage = ""Error loading external login information during confirmation."";
                return RedirectToPage(""./Login"", new { ReturnUrl = returnUrl });
            }

            if (ModelState.IsValid)
            {
                var user = new ");
#nullable restore
#line 143 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Account.ExternalLogin.cs.cshtml"
                           Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" { UserName = Input.Email, Email = Input.Email };

                var result = await _userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation(""User created an account using {Name} provider."", info.LoginProvider);

                        var userId = await _userManager.GetUserIdAsync(user);
                        var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                        code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
                        var callbackUrl = Url.Page(
                            ""/Account/ConfirmEmail"",
                            pageHandler: null,
                            values: new { area = ""Identity"", userId = userId, code = code },
                            protocol: Request.Scheme);

       ");
            WriteLiteral(@"                 await _emailSender.SendEmailAsync(Input.Email, ""Confirm your email"",
                            $""Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>."");

                        // If account confirmation is required, we need to show the link if we don't have a real email sender
                        if (_userManager.Options.SignIn.RequireConfirmedAccount)
                        {
                            return RedirectToPage(""./RegisterConfirmation"", new { Email = Input.Email });
                        }

                        await _signInManager.SignInAsync(user, isPersistent: false, info.LoginProvider);

                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            ProviderDisplayNam");
            WriteLiteral("e = info.ProviderDisplayName;\r\n            ReturnUrl = returnUrl;\r\n            return Page();\r\n        }\r\n    }\r\n}");
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
