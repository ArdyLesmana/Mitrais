#pragma checksum "C:\Users\ASUS\source\repos\Mitrais_Test_Web\Mitrais_Test_Web\Views\Shared\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a97a5befde07566d7246d59f02eddbfa9ae0379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_HomePage), @"mvc.1.0.view", @"/Views/Shared/HomePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/HomePage.cshtml", typeof(AspNetCore.Views_Shared_HomePage))]
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
#line 1 "C:\Users\ASUS\source\repos\Mitrais_Test_Web\Mitrais_Test_Web\Views\_ViewImports.cshtml"
using Mitrais_Test_Web;

#line default
#line hidden
#line 2 "C:\Users\ASUS\source\repos\Mitrais_Test_Web\Mitrais_Test_Web\Views\_ViewImports.cshtml"
using Mitrais_Test_Web.Models;

#line default
#line hidden
#line 1 "C:\Users\ASUS\source\repos\Mitrais_Test_Web\Mitrais_Test_Web\Views\Shared\HomePage.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a97a5befde07566d7246d59f02eddbfa9ae0379", @"/Views/Shared/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba74d6dda0fe5de24c1f5c70b28c2d82b551327f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 37, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            EndContext();
            BeginContext(72, 273, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a97a5befde07566d7246d59f02eddbfa9ae03793591", async() => {
                BeginContext(78, 117, true);
                WriteLiteral("\r\n\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\">\r\n    <title>");
                EndContext();
                BeginContext(196, 13, false);
#line 9 "C:\Users\ASUS\source\repos\Mitrais_Test_Web\Mitrais_Test_Web\Views\Shared\HomePage.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(209, 129, true);
                WriteLiteral("</title>\r\n\r\n    <!-- Custom fonts for this template -->\r\n    <!-- Custom styles for this page -->    \r\n\r\n    <!-- AngularJS -->\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(345, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(347, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a97a5befde07566d7246d59f02eddbfa9ae03795393", async() => {
                BeginContext(353, 80, true);
                WriteLiteral("\r\n    <div class=\"content-wrapper\">\r\n        <div class=\"content\">\r\n            ");
                EndContext();
                BeginContext(434, 12, false);
#line 19 "C:\Users\ASUS\source\repos\Mitrais_Test_Web\Mitrais_Test_Web\Views\Shared\HomePage.cshtml"
       Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(446, 310, true);
                WriteLiteral(@"
        </div>
    </div>
     
        

    
    <footer class=""sticky-footer bg-white"">
        <div class=""container my-auto"">
            <div class=""copyright text-center my-auto"">
                <span>Copyright &copy; Apps 2019</span>
            </div>
        </div>
    </footer>


");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(763, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
