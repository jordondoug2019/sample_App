#pragma checksum "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "308821e509e04f591efa0d6a842aea0f8620614b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_IdentityHostingStartup), @"mvc.1.0.view", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308821e509e04f591efa0d6a842aea0f8620614b", @"/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml")]
    public class Templates_ViewGenerator_5_0_1_Templates_Identity_Versioned_Bootstrap3_IdentityHostingStartup : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("using System;\r\n");
#nullable restore
#line 5 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
  
    var namespaceSet = new HashSet<string>(
        new string[]
        {
            "Microsoft.AspNetCore.Identity",
            "Microsoft.AspNetCore.Identity.UI",
            "Microsoft.AspNetCore.Hosting",
            "Microsoft.EntityFrameworkCore",
            "Microsoft.Extensions.Configuration",
            "Microsoft.Extensions.DependencyInjection",
        });
    var thisNamespace = $"{Model.Namespace}.Areas.Identity";

    if (!string.IsNullOrEmpty(Model.UserClassNamespace) && thisNamespace != Model.UserClassNamespace)
    {
        namespaceSet.Add(Model.UserClassNamespace);
    }
    else
    {
        namespaceSet.Add("Microsoft.AspNetCore.Identity.EntityFrameworkCore");
    }
    if (thisNamespace != Model.DbContextNamespace)
    {
        namespaceSet.Add(Model.DbContextNamespace);
    }
    foreach(var name in namespaceSet.OrderBy(n => n))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("using ");
#nullable restore
#line 32 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
   Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n");
#nullable restore
#line 33 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n[assembly: HostingStartup(typeof(");
#nullable restore
#line 36 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                             Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral(".IdentityHostingStartup))]\r\nnamespace ");
#nullable restore
#line 37 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
      Write(thisNamespace);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n{\r\n    public class IdentityHostingStartup : IHostingStartup\r\n    {\r\n        public void Configure(IWebHostBuilder builder)\r\n        {\r\n");
            WriteLiteral("            builder.ConfigureServices((context, services) => {\r\n");
#nullable restore
#line 45 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"

    if (!Model.IsUsingExistingDbContext)
    {
        if (Model.UseSQLite)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                services.AddDbContext<");
#nullable restore
#line 50 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                                   Write(Model.DbContextClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(">(options =>\r\n");
            WriteLiteral("                    options.UseSqlite(\r\n");
            WriteLiteral("                        context.Configuration.GetConnectionString(\"");
#nullable restore
#line 52 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                                                                 Write(Model.DbContextClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("Connection\")));\r\n");
#nullable restore
#line 53 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
        } // End if Model.UseSQLite
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                services.AddDbContext<");
#nullable restore
#line 56 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                                   Write(Model.DbContextClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(">(options =>\r\n");
            WriteLiteral("                    options.UseSqlServer(\r\n");
            WriteLiteral("                        context.Configuration.GetConnectionString(\"");
#nullable restore
#line 58 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                                                                 Write(Model.DbContextClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("Connection\")));\r\n");
#nullable restore
#line 59 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
        } // End else

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                services.AddDefaultIdentity<");
#nullable restore
#line 62 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                                          Write(Model.UserClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(">(options => options.SignIn.RequireConfirmedAccount = true)\r\n");
            WriteLiteral("                    .AddEntityFrameworkStores<");
#nullable restore
#line 63 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"
                                           Write(Model.DbContextClass);

#line default
#line hidden
#nullable disable
            WriteLiteral(">();\r\n");
#nullable restore
#line 64 "/home/student/CodeSchool/IdeaProjects/sample_App/MvcMovie/Templates/ViewGenerator/5.0.1/Templates/Identity_Versioned/Bootstrap3/IdentityHostingStartup.cshtml"

    } // End Model.IsUsingExstingDbContext


#line default
#line hidden
#nullable disable
            WriteLiteral("            });\r\n");
            WriteLiteral("        }\r\n    }\r\n}");
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
