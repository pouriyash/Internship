#pragma checksum "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\EmailTemplates\_TwoFactorSendCode.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b1baac4b4be64be2b49357031b181ad56692bd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_EmailTemplates__TwoFactorSendCode), @"mvc.1.0.view", @"/Areas/Identity/Views/EmailTemplates/_TwoFactorSendCode.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/EmailTemplates/_TwoFactorSendCode.cshtml", typeof(AspNetCore.Areas_Identity_Views_EmailTemplates__TwoFactorSendCode))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts;

#line default
#line hidden
#line 7 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 8 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Emails;

#line default
#line hidden
#line 9 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 10 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 11 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 12 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 13 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 14 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 15 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 16 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Infrastructure.Services.Contracts.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b1baac4b4be64be2b49357031b181ad56692bd8", @"/Areas/Identity/Views/EmailTemplates/_TwoFactorSendCode.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8855e927cc29baffb9e09864cdbecda77e26a913", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_EmailTemplates__TwoFactorSendCode : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TwoFactorSendCodeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("align", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("ltr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("rtl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Tahoma; font-size: 9pt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\EmailTemplates\_TwoFactorSendCode.cshtml"
  
    Layout = "~/Areas/Identity/Views/EmailTemplates/_EmailsLayout.cshtml";

#line default
#line hidden
            BeginContext(118, 88, true);
            WriteLiteral("&nbsp; با سلام\r\n<br />\r\n&nbsp;کد جدید اعتبارسنجی دو مرحله‌ای شما عبارت‌است از:\r\n<br />\r\n");
            EndContext();
            BeginContext(206, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b1baac4b4be64be2b49357031b181ad56692bd87459", async() => {
                BeginContext(280, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(286, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b1baac4b4be64be2b49357031b181ad56692bd87843", async() => {
                    BeginContext(316, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(327, 11, false);
#line 11 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\EmailTemplates\_TwoFactorSendCode.cshtml"
   Write(Model.Token);

#line default
#line hidden
                    EndContext();
                    BeginContext(338, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(350, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(358, 71, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n&nbsp;با احترام<br />\r\n&nbsp;<a style=\"direction:ltr\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 429, "\"", 529, 1);
#line 17 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\EmailTemplates\_TwoFactorSendCode.cshtml"
WriteAttributeValue("", 436, Url.Action("Index", "Home" , values: new { area="" }, protocol: this.Context.Request.Scheme), 436, 93, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(530, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(532, 20, false);
#line 17 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\EmailTemplates\_TwoFactorSendCode.cshtml"
                                                                                                                               Write(Model.EmailSignature);

#line default
#line hidden
            EndContext();
            BeginContext(552, 64, true);
            WriteLiteral("</a>\r\n<br />\r\n<span lang=\"fa\" dir=\"ltr\">\r\n    &nbsp;&nbsp;\r\n    ");
            EndContext();
            BeginContext(617, 21, false);
#line 21 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\EmailTemplates\_TwoFactorSendCode.cshtml"
Write(Model.MessageDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(638, 17, true);
            WriteLiteral("\r\n</span>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TwoFactorSendCodeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
