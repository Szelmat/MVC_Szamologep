#pragma checksum "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82bf74e97dd723780d1670aca7fc7bfad174b812"
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
#line 1 "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\_ViewImports.cshtml"
using Szeles_Mate_szamologep;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\_ViewImports.cshtml"
using Szeles_Mate_szamologep.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82bf74e97dd723780d1670aca7fc7bfad174b812", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a2cd6bdf51289176bfdc5bd912ab2369d4f098", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Equals", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Számológép";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\Home\Index.cshtml"
 using (Html.BeginForm("Equals", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""text-center"" id=""calculator"">
        <div id=""screen"">
            <input name=""firstTypingRow"" id=""firstTypingRow"" class=""typing-row form-control"" style=""background-color:transparent;border:1px solid transparent;padding:0px"" />

            <input name=""secondTypingRow"" id=""secondTypingRow"" class=""typing-row form-control"" style=""background-color:transparent;border:1px solid transparent;padding:0px"" />

            <div id=""answer-row"">");
#nullable restore
#line 13 "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\Home\Index.cshtml"
                            Write(ViewData["Result"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
        </div>

        <div id=""buttons"">
            <div class=""calc-row"" id=""row1"">
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(7);"" style=""cursor: pointer;"">7</a>
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(8);"" style=""cursor: pointer;"">8</a>
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(9);"" style=""cursor: pointer;"">9</a>
                <a class=""btn btn-secondary btn-lg"" onclick=""typeSign('+');"" style=""cursor: pointer;"">+</a>
            </div>

            <div class=""calc-row"" id=""row2"">
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(4);"" style=""cursor: pointer;"">4</a>
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(5);"" style=""cursor: pointer;"">5</a>
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(6);"" style=""cursor: pointer;"">6</a>
                <a class=""btn btn-secondary btn-lg"" onclick=""typeSign('-');"" style=""cursor: pointer;"">-</a>
            </div>

    ");
            WriteLiteral(@"        <div class=""calc-row"" id=""row3"">
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(1);"" style=""cursor: pointer;"">1</a>
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(2);"" style=""cursor: pointer;"">2</a>
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(3);"" style=""cursor: pointer;"">3</a>
                <a class=""btn btn-secondary btn-lg"" onclick=""typeSign('×');"" style=""cursor: pointer;"">×</a>
            </div>

            <div class=""calc-row"" id=""row4"">
                <a class=""btn btn-light btn-lg"" onclick=""typeNum(0);"" style=""cursor: pointer;"">0</a>
                <a class=""btn btn-secondary btn-lg"" onclick=""typeNum(',')"" style=""cursor: pointer;"">,</a>
                <a class=""btn btn-secondary btn-lg"" onclick=""typeSign('/');"" style=""cursor: pointer;"">/</a>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "82bf74e97dd723780d1670aca7fc7bfad174b8127306", async() => {
                WriteLiteral(" = ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 46 "D:\Projects\CS\MVC_Szamologep\Szeles_Mate_szamologep\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
