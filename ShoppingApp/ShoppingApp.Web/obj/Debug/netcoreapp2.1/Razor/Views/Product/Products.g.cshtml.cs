#pragma checksum "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54f2015926139d4bf228a668ab7893ec133f485c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Products), @"mvc.1.0.view", @"/Views/Product/Products.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Products.cshtml", typeof(AspNetCore.Views_Product_Products))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54f2015926139d4bf228a668ab7893ec133f485c", @"/Views/Product/Products.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9eb9d63edeb435c742d3b024399b31f8c81212a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Products : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
  
    ViewData["Title"] = "Products";

#line default
#line hidden
            BeginContext(75, 47, true);
            WriteLiteral("\r\n<h1>Products</h1>\r\n\r\n<div class=\"products\">\r\n");
            EndContext();
#line 9 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
            BeginContext(166, 45, true);
            WriteLiteral("        <div class=\"thumbnail\">\r\n            ");
            EndContext();
            BeginContext(211, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f61601b242ca41318c9f8b556280081f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 243, "~/images/Products/product-", 243, 26, true);
#line 12 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
AddHtmlAttributeValue("", 269, product.Id, 269, 13, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 282, ".png", 282, 4, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(300, 53, true);
            WriteLiteral("\r\n            <div class=\"caption\">\r\n                ");
            EndContext();
            BeginContext(353, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a744cf25818a4982aaeea3ee9207cedf", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 14 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => product.Id);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("hidden", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(391, 22, true);
            WriteLiteral("\r\n                <h3>");
            EndContext();
            BeginContext(414, 12, false);
#line 15 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(426, 27, true);
            WriteLiteral("</h3>\r\n                <h4>");
            EndContext();
            BeginContext(454, 19, false);
#line 16 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
               Write(product.Description);

#line default
#line hidden
            EndContext();
            BeginContext(473, 27, true);
            WriteLiteral("</h4>\r\n                <h5>");
            EndContext();
            BeginContext(501, 13, false);
#line 17 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
               Write(product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(514, 35, true);
            WriteLiteral(" $</h5>\r\n                <p><button");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 549, "\"", 568, 1);
#line 18 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
WriteAttributeValue("", 557, product.Id, 557, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(569, 113, true);
            WriteLiteral(" class=\"btn btn-primary productItem\" role=\"button\">Add to cart</button></p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 21 "D:\VladP_Apps\AspNetApps\LamazonApp\SEDC.Lazamazon.Web\Views\Product\Products.cshtml"
    }

#line default
#line hidden
            BeginContext(689, 731, true);
            WriteLiteral(@"</div>

<script>
    let products = document.getElementsByClassName(""products"")[0];
    console.log(products);
    products.addEventListener(""click"", function (e) {
        e.stopPropagation();
        let target = e.target;
        console.log(target);

        let targetId = target.classList.contains(""productItem"") ? target.value : null;
        console.log(targetId);
        if (targetId != null) {
            fetch(""/Order/AddProduct?productId="" + targetId, {
                method: ""post"",
            })
            //    .then(res => { 
            //    let data = res;

            //    fetch(""/Order/GetMessageResult?result="" + data);
            //});
        }
    });

</script>




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
