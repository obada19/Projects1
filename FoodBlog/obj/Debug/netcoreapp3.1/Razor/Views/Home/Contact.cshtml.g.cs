#pragma checksum "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d0ca95a786731c9008754ea2dc9d24b9c56aeea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d0ca95a786731c9008754ea2dc9d24b9c56aeea", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c0be69bf439b206259bac226fdf4bded2c2f7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Contact.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Contact.cshtml"
 using (Html.BeginForm("SendMail", "Home"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"" id=""contactcontainer"">
        <h1>Contact us!</h1>
        <div class=""container"">
            <label>Email</label>
            <div class=""form-group"">
                <input name=""email"" type=""text"" class=""form-group"" id=""emailcontact"">
            </div>
        </div>
        <div class=""container"">
            <label>Subject</label>
            <div class=""form-group"">
                <input name=""title"" type=""text"" class=""form-group"" id=""titlecontact"">
            </div>
        </div>
        <div class=""col-md-container"">
            <label>Message</label>
            <div class=""form-group"">
                <textarea name=""content"" class=""form-group"" id=""contentcontact""></textarea>
            </div>
        </div>
        <div class=""container"">
            <div class=""form-group"">
                <button class=""btn btn-primary"" type=""submit"">Send message</button>
            </div>
        </div>

    </div>
");
#nullable restore
#line 36 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Contact.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n");
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