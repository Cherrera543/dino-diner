#pragma checksum "C:\Users\colum\Downloads\CIS 400\dino-diner\dino-diner\Website\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31d6af98d90d874addfcdaf813efe737d40e132a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Website.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/About.cshtml", typeof(Website.Pages.Pages_About), null)]
namespace Website.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\colum\Downloads\CIS 400\dino-diner\dino-diner\Website\Pages\_ViewImports.cshtml"
using Website;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31d6af98d90d874addfcdaf813efe737d40e132a", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c79ec0c32609373f73329000ddfbb44dcd14c296", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\colum\Downloads\CIS 400\dino-diner\dino-diner\Website\Pages\About.cshtml"
  
    ViewData["Title"] = "About Us";

#line default
#line hidden
            BeginContext(84, 565, true);
            WriteLiteral(@"<img src=""https://k-state.instructure.com/courses/83099/files/10852332/preview"" alt=""logo"" />
<h1>About Dino Diner</h1>
<p style=""font-style: italic; text-align: center"">
    Founded in 2019 from the collective collective consciousness of the Fall Semester CIS 400 students of Kansas State University, 
    Dino-Diner is devoted to bringing you the finest in dinosaur-themed dining experiences. 
    Despite the prehistoric nature of our menu, we only use the freshest of ingredients, and no dinosaurs were harmed to bring our delectable fare to you.
</p>

");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Website.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Website.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Website.Pages.AboutModel>)PageContext?.ViewData;
        public Website.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591