#pragma checksum "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77eb9819892dec3dc8ddad4f42bccfcda00ba3f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_success), @"mvc.1.0.view", @"/Views/Home/success.cshtml")]
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
#line 1 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\_ViewImports.cshtml"
using FoodBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\_ViewImports.cshtml"
using FoodBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77eb9819892dec3dc8ddad4f42bccfcda00ba3f7", @"/Views/Home/success.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c0be69bf439b206259bac226fdf4bded2c2f7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\success.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <h1>Thanks for your order!</h1>
    <link rel=""stylesheet"" href=""style.css"">


<section>
    <p>
        We appreciate your business! If you have any questions, please email
        <a href=""bluerose.ikt201g20h.gmail.com"">bluerose.ikt201g20h.gmail.com</a>.
    </p>
</section>

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
