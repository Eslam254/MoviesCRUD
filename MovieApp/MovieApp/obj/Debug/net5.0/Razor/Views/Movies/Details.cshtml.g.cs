#pragma checksum "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a579c64d1752434b92737dbc1bcbe653a7ce36a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#nullable restore
#line 1 "F:\ITI\projects\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ITI\projects\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ITI\projects\MovieApp\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a579c64d1752434b92737dbc1bcbe653a7ce36a", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d12d6c878c92d9589263ae212816a94f6d7fa93d", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
  
  ViewData["Title"] = Model.title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-between mt-60-px\">\r\n  <div class=\"col-md-3\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 147, "\"", 212, 2);
            WriteAttributeValue("", 153, "data:image/*;base64,", 153, 20, true);
#nullable restore
#line 9 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
WriteAttributeValue("", 173, Convert.ToBase64String(Model.poster), 173, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\"");
            BeginWriteAttribute("alt", " alt=\"", 235, "\"", 253, 1);
#nullable restore
#line 9 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
WriteAttributeValue("", 241, Model.title, 241, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n  </div>\r\n  <div class=\"col-md-7\">\r\n    <div class=\"d-flex justify-content-between mb-3\">\r\n      <h3>");
#nullable restore
#line 13 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
     Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n      <span class=\"mt-2\">\r\n        <i class=\"bi bi-star-fill text-warning\"></i>\r\n        <span class=\"text-muted\">");
#nullable restore
#line 16 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
                            Write(Model.Rate.ToString("0.0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n      </span>\r\n    </div>\r\n    <span class=\"text-muted mr-3\">\r\n      <i class=\"bi bi-calendar-week\"></i>\r\n      ");
#nullable restore
#line 21 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
 Write(Model.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </span>\r\n");
            WriteLiteral("    <p class=\"text-justify mt-3\">");
#nullable restore
#line 27 "F:\ITI\projects\MovieApp\MovieApp\Views\Movies\Details.cshtml"
                            Write(Model.storyLine);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
