#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Data/ApplicationUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc95a22cc504a5c92c61194f3b6afdfbaa620dd6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ControllerGenerator_5_0_1_Templates_Identity_Data_ApplicationUser), @"mvc.1.0.view", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Data/ApplicationUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc95a22cc504a5c92c61194f3b6afdfbaa620dd6", @"/Templates/ControllerGenerator/5.0.1/Templates/Identity/Data/ApplicationUser.cshtml")]
    public class Templates_ControllerGenerator_5_0_1_Templates_Identity_Data_ApplicationUser : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\nusing System.Collections.Generic;\r\nusing System.Linq;\r\nusing System.Threading.Tasks;\r\nusing Microsoft.AspNetCore.Identity;\r\n\r\nnamespace ");
#nullable restore
#line 8 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Data/ApplicationUser.cshtml"
      Write(Model.UserClassNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    // Add profile data for application users by adding properties to the ");
#nullable restore
#line 10 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Data/ApplicationUser.cshtml"
                                                                     Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(" class\r\n    public class ");
#nullable restore
#line 11 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ControllerGenerator/5.0.1/Templates/Identity/Data/ApplicationUser.cshtml"
            Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : IdentityUser\r\n    {\r\n    }\r\n}\r\n");
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
