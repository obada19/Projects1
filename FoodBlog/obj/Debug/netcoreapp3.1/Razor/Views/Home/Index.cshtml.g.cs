#pragma checksum "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73c3e95768799149c19016c7c16aa61ff5edb983"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 5 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Index.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73c3e95768799149c19016c7c16aa61ff5edb983", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0c0be69bf439b206259bac226fdf4bded2c2f7e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Privacy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\obada\ikt201g20h\assignments\bluerose\FoodBlog\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
	Layout="_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""slides"" class=""carousel slide"" data-ride=""carousel"">
	<ul class=""carousel-indicators"">
		<li data-target=""#slides"" data-slide-to=""0"" class=""active""></li>
		<li data-target=""#slides"" data-slide-to=""1""></li>
		<li data-target=""#slides"" data-slide-to=""2""></li>
	</ul>
	<div class=""carousel-inner"">
		<div class=""carousel-item active"">
			<img src=""pexels-engin-akyurt-1435895.jpg"">
			<div class=""carousel-caption"">
				<h1 class=""display-2"">Cooking</h1>
				<h3>Header 3</h3>
				<button type=""button"" class=""btn btn-outline-light btn-lg"">SIGN UP</button>
			</div>
		</div>
		<div class=""carousel-item"">
			<img src=""pexels-maarten-van-den-heuvel-2284166.jpg"">
		</div>
		<div class=""carousel-item"">
			<img src=""pexels-lukas-952478.jpg"">
		</div>
		
	</div>
</div>


<div class=""container-fluid"">
	<div class=""container-fluid"">
		<div class=""row jumbotron"">
			<div class=""col-xs-12 col-sm-12 col-md-9 col-lg-9 col-xl-10"">
				<p class=""lead"">
					Lorem ipsum dolor sit amet, conse");
            WriteLiteral(@"ctetur adipiscing elit. Suspendisse volutpat in justo in molestie. Pellentesque eleifend leo et nulla ornare, nec pulvinar quam congue.
				</p>
				<div class=""col-xs-12 col-sm-12 col-md-3 col-lg-3 col-xl-2"">
					<a href=""#""><button type=""button"" class=""btn btn-outline-secondary"">Button</button></a>
				</div>
			</div>
		</div>
	</div>
</div>




<!--- Buy Book -->

<div class=""row padding"">
	<div class=""col-6"">
		<h2>Buy our own cook book</h2>
		<p>
			Click on the button below to buy our cook book which contains the editors selections of the best recipies posted on this site.
		</p>
		<div class=""col-6"">
			<div class=""card"">
			<img
				src=""pexels-skitterphoto-1005324.jpg""
				alt=""Book photo""
				width=""200""/>
			<h1>Bluerose Cook Book</h1>
			<p class=""price""> 300 kr</p>
			
			<button id=""checkout-button"" class=""btn btn-primary"">Buy now</button></div>
		</div>
<script type=""text/javascript"">
    // Create an instance of the Stripe object with your publishable API key");
            WriteLiteral(@"
    var stripe = Stripe(""pk_test_51HtOk2GZGPrFNUvXZqk9W2hxvsHllQ7KR99py1Y0J76om6lEs15saadIZsAkIQPhePLiDkRXysBJWI4dvviwjcp4002DkzzvSG"");
    var checkoutButton = document.getElementById(""checkout-button"");
    checkoutButton.addEventListener(""click"", function () {
        fetch(""/create-session"", {
            method: ""POST"",
        })
            .then(function (response) {
                return response.json();
            })
            .then(function (session) {
                return stripe.redirectToCheckout({ sessionId: session.id });
            })
            .then(function (result) {
                // If redirectToCheckout fails due to a browser or network
                // error, you should display the localized error message to your
                // customer using error.message.
                if (result.error) {
                    alert(result.error.message);
                }
            })
            .catch(function (error) {
                console.error(""Error:""");
            WriteLiteral(@", error);
            });
    });
</script>
		</div>
	</div>

<hr class=""light""></hr>



<!--- Two Column Section -->
<div class=""container-fluid padding"">
	<div class=""row padding"">
		<div class=""col-lg-6"">
			<h2>Our Philosophy</h2>
			<p>
				Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse volutpat in justo in molestie. Pellentesque eleifend leo et nulla ornare, nec pulvinar quam congue. Suspendisse libero tortor, gravida id dignissim ut, mollis ac ipsum. Integer efficitur quam libero, ac mattis dui ultrices id
			</p>
			<p>
				Suspendisse et ligula sit amet dui aliquet posuere. Proin ullamcorper sem sit amet purus feugiat blandit semper et tortor. Proin consequat varius sapien, vitae eleifend mi tincidunt id. Phasellus pulvinar accumsan felis, eu condimentum nunc fringilla sed. Integer sit amet nunc et turpis congue pellentesque. Vestibulum a dui sed lectus sagittis facilisis nec suscipit elit. Aliquam posuere varius enim, sed interdum felis mollis eget.
			</p>");
            WriteLiteral(@"
			<p>
				In leo elit, fermentum ut diam non, ultrices eleifend nunc. Nunc nisl risus, dignissim ut imperdiet a, porttitor ac urna. Sed purus erat, posuere eget urna non, volutpat commodo sem. Donec tellus elit, accumsan sit amet congue in, ornare et ligula. Nullam odio nisi, tincidunt nec nibh a, egestas sagittis justo.
			</p>
			<br>
			</div>
		<div class=""col-lg-6"">
			<img src=""pexels-pixabay-461428.jpg"" class=""img-fluid""></img>


		</div>
	</div>
</div>

<!--- Connect -->
<div class=""container-fluid padding"">
	<div class=""row text-center padding"">
		<div class=""col-12"">
			<h2>Social media</h2>
		</div>
		<div class=""col-12 social padding"">
			<a href=""https://www.facebook.com/sondre.eftedal.9/""><i class=""fab fa-facebook""></i> </a>
			<a href=""https://twitter.com/""><i class=""fab fa-twitter""></i> </a>
			<a href=""https://www.instagram.com/""><i class=""fab fa-instagram""></i> </a>
		</div>
	</div>
</div>

<!--- Footer -->
<footer>
	<div class=""container-fluid padding"">
		<d");
            WriteLiteral(@"iv class=""row text-center"">
			<div class=""col-md-6"">
				<img src=""Bluerose.png"" width=""300px"" >
				<hr class=""light"">
				<p>93497708</p>
				<p>info@bluerose.no</p>
				<p>Navneveien 54</p>
				<p>4633 Kristiansand S</p>
			</div>
			<div class=""col-md-6"">
				<hr class=""light"">
				<h5>Opening hours</h5>
				<hr class=""light"">
				<p>Monday-Friday: 8:00-16:00</p>
				<p>Saturday: 10:00-16:00</p>
				<p>Sunday: closed</p>
			</div>
		</div>
	</div>
	
            <div class=""container"">
                &copy; 2020 - FoodBlog - ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73c3e95768799149c19016c7c16aa61ff5edb98310364", async() => {
                WriteLiteral("Privacy");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        \r\n</footer>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptions<StripeSettings> Stripe { get; private set; }
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
