#pragma checksum "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\Shared\_LoginPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b8d299e3118dcf0b15d95ef53114763b260260b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoginPartial), @"mvc.1.0.view", @"/Views/Shared/_LoginPartial.cshtml")]
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
#line 1 "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\_ViewImports.cshtml"
using AppScheduling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\_ViewImports.cshtml"
using AppScheduling.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b8d299e3118dcf0b15d95ef53114763b260260b", @"/Views/Shared/_LoginPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fea9f4e44ae0d373eca8dcfdc1d4eeafbbb96df", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoginPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\Shared\_LoginPartial.cshtml"
 if(signInManager.IsSignedIn(User))
{

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul class=\"nav navbar-nav\">\r\n    <li>");
#nullable restore
#line 9 "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\Shared\_LoginPartial.cshtml"
   Write(Html.ActionLink("Sign Up", "Register", "Account", routeValues: null, htmlAttributes: new { id = "registerlink" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 10 "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\Shared\_LoginPartial.cshtml"
   Write(Html.ActionLink("Sign In", "Login", "Account", routeValues: null, htmlAttributes: new { id = "loginlink" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
#nullable restore
#line 12 "E:\Praveena\MVC5\AppScheduling\AppScheduling\Views\Shared\_LoginPartial.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Identity.SignInManager<Microsoft.AspNetCore.Identity.IdentityUser> signInManager { get; private set; }
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
