#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cac0746b9c565e6ceda2accfb27c13b223c12d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_Index_cs), @"mvc.1.0.view", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cac0746b9c565e6ceda2accfb27c13b223c12d6", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_Index_cs : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.ComponentModel.DataAnnotations;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\n");
#nullable restore
#line 9 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
  
    var namespaceSet = new HashSet<string>(
        new string[]
        {
            "Microsoft.AspNetCore.Identity",
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.RazorPages",
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
#line 25 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 26 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 29 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
     Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public partial class IndexModel : PageModel\r\n    {\r\n        private readonly UserManager<");
#nullable restore
#line 33 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
                                 Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _userManager;\r\n        private readonly SignInManager<");
#nullable restore
#line 34 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
                                   Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _signInManager;\r\n\r\n        public IndexModel(\r\n            UserManager<");
#nullable restore
#line 37 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
                    Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> userManager,\r\n            SignInManager<");
#nullable restore
#line 38 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
                      Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Phone]
            [Display(Name = ""Phone number"")]
            public string PhoneNumber { get; set; }
        }

        private async Task LoadAsync(");
#nullable restore
#line 59 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cs.cshtml"
                                 Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" user)
        {
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            if (!ModelState.IsVali");
            WriteLiteral(@"d)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = ""Unexpected error when trying to set phone number."";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = ""Your profile has been updated"";
            return RedirectToPage();
        }
    }
}
");
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
