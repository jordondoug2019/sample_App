#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.PersonalData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b298b07a8d03fd60a8e5c93abe46c80faffc31dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_PersonalData), @"mvc.1.0.razor-page", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.PersonalData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b298b07a8d03fd60a8e5c93abe46c80faffc31dd", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.PersonalData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_PersonalData : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.PersonalData.cshtml"
  
    ViewData["Title"] = "Personal Data";
    ViewData["ActivePage"] = ManageNavPages.PersonalData;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.PersonalData.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>

<div class=""row"">
    <div class=""col-md-6"">
        <p>Your account contains personal data that you have given us. This page allows you to download or delete that data.</p>
        <p>
            <strong>Deleting this data will permanently remove your account, and this cannot be recovered.</strong>
        </p>
        <form asp-page=""DownloadPersonalData"" method=""post"" class=""form-group"">
            <button class=""btn btn-default"" type=""submit"">Download</button>
        </form>
        <p>
            <a asp-page=""DeletePersonalData"" class=""btn btn-default"">Delete</a>
        </p>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalDataModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonalDataModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PersonalDataModel>)PageContext?.ViewData;
        public PersonalDataModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
