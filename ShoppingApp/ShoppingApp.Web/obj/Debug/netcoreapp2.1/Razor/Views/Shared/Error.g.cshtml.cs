#pragma checksum "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "416afa14cf2c9b7d860eedfe665d215f9130725c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Error.cshtml", typeof(AspNetCore.Views_Shared_Error))]
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
#line 1 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\_ViewImports.cshtml"
using ShoppingApp.Web;

#line default
#line hidden
#line 2 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\_ViewImports.cshtml"
using ShoppingApp.Web.Models;

#line default
#line hidden
#line 3 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\_ViewImports.cshtml"
using ShoppingApp.WebModels_.ViewModels;

#line default
#line hidden
#line 4 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\_ViewImports.cshtml"
using ShoppingApp.WebModels_.Enums;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"416afa14cf2c9b7d860eedfe665d215f9130725c", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9eb9d63edeb435c742d3b024399b31f8c81212a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(64, 119, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n\r\n<h1 class=\"text-danger\">You are not authorized to see this order!!!</h1>\r\n\r\n\r\n");
            EndContext();
#line 11 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(213, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(266, 15, false);
#line 14 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(281, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 16 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(303, 562, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>Development environment should not be enabled in deployed applications</strong>, as it can result in sensitive information from exceptions being displayed to end users. For local debugging, development environment can be enabled by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>, and restarting the application.
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
