#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5d699ef9395f8a61c84fcbc5f99b1a953916d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_Index), @"mvc.1.0.razor-page", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5d699ef9395f8a61c84fcbc5f99b1a953916d1", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8807815bf2567e292464fbd3dfad36b424717cc9", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/_ViewImports.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_Pages_Account_Manage_Account_Manage_Index : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cshtml"
  
    ViewData["Title"] = "Profile";
    ViewData["ActivePage"] = ManageNavPages.Index;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4>");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/Pages/Account/Manage/Account.Manage.Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
<partial name=""_StatusMessage"" model=""Model.StatusMessage"" />
<div class=""row"">
    <div class=""col-md-6"">
        <form id=""profile-form"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Username""></label>
                <input asp-for=""Username"" class=""form-control"" disabled />
            </div>
            <div class=""form-group"">
                <label asp-for=""Input.PhoneNumber""></label>
                <input asp-for=""Input.PhoneNumber"" class=""form-control"" />
                <span asp-validation-for=""Input.PhoneNumber"" class=""text-danger""></span>
            </div>
            <button id=""update-profile-button"" type=""submit"" class=""btn btn-default"">Save</button>
        </form>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
