#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8709721311cf2753a0dfe24f304fe3836c5df2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage_PersonalData_cs), @"mvc.1.0.view", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8709721311cf2753a0dfe24f304fe3836c5df2b", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/_ViewImports.cshtml")]
    public class Templates_ControllerGenerator_5_0_1_Templates_Identity_Pages_Account_Manage_Account_Manage_PersonalData_cs : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System.Threading.Tasks;\r\n");
#nullable restore
#line 5 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
  
    var namespaceSet = new HashSet<string>(
        new string[]
        {
            "Microsoft.AspNetCore.Mvc",
            "Microsoft.AspNetCore.Mvc.RazorPages",
            "Microsoft.AspNetCore.Identity",
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
#line 22 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 23 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nnamespace ");
#nullable restore
#line 26 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
     Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class PersonalDataModel : PageModel\r\n    {\r\n        private readonly UserManager<");
#nullable restore
#line 30 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
                                 Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("> _userManager;\r\n        private readonly ILogger<PersonalDataModel> _logger;\r\n\r\n        public PersonalDataModel(\r\n            UserManager<");
#nullable restore
#line 34 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Pages/Account/Manage/Account.Manage.PersonalData.cs.cshtml"
                    Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"> userManager,
            ILogger<PersonalDataModel> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        public async Task<IActionResult> OnGet()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($""Unable to load user with ID '{_userManager.GetUserId(User)}'."");
            }

            return Page();
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