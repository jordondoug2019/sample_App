#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "195674e9bcee1af4a0dd1af34b1e9fd32591cb38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Startup_Startup), @"mvc.1.0.view", @"/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"195674e9bcee1af4a0dd1af34b1e9fd32591cb38", @"/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Startup_Startup : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using Microsoft.AspNetCore.Builder;\r\n");
#nullable restore
#line 4 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
   
    var allNamespaces = new SortedSet<string>(StringComparer.Ordinal);
    foreach (var list in Model.StartupList)
    {
        allNamespaces.UnionWith(list.RequiredNamespaces);
    }
    foreach (var namespaceName in allNamespaces)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("using ");
#nullable restore
#line 12 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
   Write(namespaceName);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 13 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("namespace ");
#nullable restore
#line 15 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
     Write(Model.RootNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class Startup\r\n    {\r\n        public void Configure(IBuilder app)\r\n        {\r\n            // Set up application services\r\n            app.UseServices(services =>\r\n            {\r\n");
#nullable restore
#line 24 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
  
    var count = Model.StartupList.Count;
    for (var index = 0; index < count; index++)
    {
        var list = Model.StartupList[index];
        var atleastOneStatement = false;
        foreach (var statement in list.ServiceStatements)
        {
            atleastOneStatement = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 33 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
             Write(statement);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 34 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
        }
        if (atleastOneStatement && (index != count-1))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 38 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            });\r\n\r\n");
#nullable restore
#line 42 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
  
    for (var index = 0; index < count; index++)
    {
        var list = Model.StartupList[index];
        var atleastOneStatement = false;
        foreach (var statement in list.UseStatements)
        {
            atleastOneStatement = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
#nullable restore
#line 50 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
         Write(statement);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 51 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
        }
        if (atleastOneStatement && (index != count-1))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Startup/Startup.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        }\r\n    }\r\n}\r\n");
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
