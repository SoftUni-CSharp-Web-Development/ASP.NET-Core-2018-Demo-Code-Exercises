#pragma checksum "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99d9317f81ef5d67599dcc45a1b7c3086aca206f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\MVCFrameworks\Eventures\Eventures\Views\_ViewImports.cshtml"
using Eventures;

#line default
#line hidden
#line 2 "D:\MVCFrameworks\Eventures\Eventures\Views\_ViewImports.cshtml"
using Eventures.Models;

#line default
#line hidden
#line 1 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#line 2 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99d9317f81ef5d67599dcc45a1b7c3086aca206f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b4e87be21c7261c5ecebadd0aaf898da14f5a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    var currentUser = await UserManager.GetUserAsync(this.User);
    var isCurrentUserAuthenticated = this.User?.Identity?.IsAuthenticated;

#line default
#line hidden
            BeginContext(311, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
 if (isCurrentUserAuthenticated.HasValue && isCurrentUserAuthenticated.Value)
{
    if (this.User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(440, 228, true);
            WriteLiteral("        <div class=\"container\" style=\"padding: 20px 30px 0 0\">\r\n            <div class=\"jumbotron\" style=\"background-color: #AFEEEE; text-align: center\">\r\n                <h2 style=\"font-weight: bold\">Greetings, Administrator - ");
            EndContext();
            BeginContext(669, 34, false);
#line 18 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
                                                                    Write(UserManager.GetUserName(this.User));

#line default
#line hidden
            EndContext();
            BeginContext(703, 238, true);
            WriteLiteral("!</h2>\r\n                <hr style=\"height: 3px; background-color: darkgrey\" />\r\n                <p>\r\n                    <strong style=\"color: darkgrey\">Enjoy your work.</strong>\r\n                </p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 25 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(965, 210, true);
            WriteLiteral("        <div class=\"container\" style=\"padding: 20px 30px 0 0\">\r\n            <div class=\"jumbotron\" style=\"background-color: #AFEEEE; text-align: center\">\r\n                <h2 style=\"font-weight: bold\">Welcome, ");
            EndContext();
            BeginContext(1176, 34, false);
#line 30 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
                                                  Write(UserManager.GetUserName(this.User));

#line default
#line hidden
            EndContext();
            BeginContext(1210, 266, true);
            WriteLiteral(@"!</h2>
                <hr style=""height: 3px; background-color: darkgrey"" />
                <p>
                    <strong style=""color: darkgrey"">Eventures wishes you an exciting experience.</strong>
                </p>
            </div>
        </div>
");
            EndContext();
#line 37 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
    }

}
else
{

#line default
#line hidden
            BeginContext(1497, 331, true);
            WriteLiteral(@"    <div class=""container"" style=""padding: 20px 30px 0 0"">
        <div class=""jumbotron"" style=""background-color: #AFEEEE"">
            <h2 style=""font-weight: bold"">Eventures - The best ticket service in the world.</h2>
            <hr style=""height: 3px; background-color: black"" />
            <p>
                <strong>");
            EndContext();
            BeginContext(1828, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5f99feed8354931a710dc60c7fa1d57", async() => {
                BeginContext(1875, 5, true);
                WriteLiteral("Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1884, 91, true);
            WriteLiteral(" to start \"eventing\".</strong>\r\n            </p>\r\n            <p>\r\n                <strong>");
            EndContext();
            BeginContext(1975, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85d472f6c0ae448282445d929b7c34e4", async() => {
                BeginContext(2025, 8, true);
                WriteLiteral("Register");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2037, 87, true);
            WriteLiteral(" if you don\'t have an account.</strong>\r\n            </p>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 54 "D:\MVCFrameworks\Eventures\Eventures\Views\Home\Index.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<EventuresUser> UserManager { get; private set; }
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