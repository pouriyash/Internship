#pragma checksum "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeafff8c4b46579d9f8205fd9b0ff3f3c93232ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Routine2__ChangeStep), @"mvc.1.0.view", @"/Views/Shared/_Routine2/_ChangeStep.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Routine2/_ChangeStep.cshtml", typeof(AspNetCore.Views_Shared__Routine2__ChangeStep))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 6 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 7 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 8 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 9 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 10 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 11 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 12 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 13 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Infrastructure.DataLayer.Context;

#line default
#line hidden
#line 14 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.AuditableEntity;

#line default
#line hidden
#line 1 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
using Internship.Core.DomainModels.Entity.Routine2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eeafff8c4b46579d9f8205fd9b0ff3f3c93232ec", @"/Views/Shared/_Routine2/_ChangeStep.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51872ae7d6162f128a2b528f6a5dce7432e7ca3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Routine2__ChangeStep : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Internship.Core.DomainModels.ViewModel.Routine2.Routine2ChangeStep>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-role", new global::Microsoft.AspNetCore.Html.HtmlString("routine-ajax-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-role", new global::Microsoft.AspNetCore.Html.HtmlString("popover-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(128, 9, true);
            WriteLiteral("\r\n\r\n<span");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 137, "\"", 158, 1);
#line 5 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 145, Model.Action, 145, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(159, 30, true);
            WriteLiteral("\r\n      style=\"display: none;\"");
            EndContext();
            BeginWriteAttribute("id", "\r\n      id=\"", 189, "\"", 262, 4);
            WriteAttributeValue("", 201, "routine_record_action_tooltip_", 201, 30, true);
#line 7 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 231, Model.Action, 231, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 246, "_", 246, 1, true);
#line 7 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 247, Model.EntityId, 247, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(263, 28, true);
            WriteLiteral(">\r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", "\r\n            id=\"", 291, "\"", 362, 4);
            WriteAttributeValue("", 309, "routine_record_action_", 309, 22, true);
#line 9 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 331, Model.Action, 331, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 346, "_", 346, 1, true);
#line 9 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 347, Model.EntityId, 347, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 43, true);
            WriteLiteral("\r\n            data-popover=\"Routine_Action_");
            EndContext();
            BeginContext(408, 12, false);
#line 10 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
                                     Write(Model.Action);

#line default
#line hidden
            EndContext();
            BeginContext(421, 1, true);
            WriteLiteral("_");
            EndContext();
            BeginContext(423, 14, false);
#line 10 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
                                                    Write(Model.EntityId);

#line default
#line hidden
            EndContext();
            BeginContext(437, 136, true);
            WriteLiteral("\"\r\n            class=\"exir--transparent-btn\">\r\n        <i data-role=\"icon\" class=\"pe-7s-play largeicon\"></i>\r\n    </button>\r\n</span>\r\n\r\n");
            EndContext();
            BeginContext(573, 912, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeafff8c4b46579d9f8205fd9b0ff3f3c93232ec9636", async() => {
                BeginContext(658, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(664, 813, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eeafff8c4b46579d9f8205fd9b0ff3f3c93232ec10021", async() => {
                    BeginContext(700, 40, true);
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 740, "\"", 763, 1);
#line 18 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 748, Model.EntityId, 748, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(764, 47, true);
                    WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Action\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 811, "\"", 832, 1);
#line 19 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 819, Model.Action, 819, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(833, 609, true);
                    WriteLiteral(@" />

        <textarea class=""form-control"" name=""Description""
                  oninvalid=""this.setCustomValidity('لطفا پیش از ارسال، توضیحات را کامل نمایید')""
                  oninput=""this.setCustomValidity('')""
                  style=""resize: none; height: 180px; overflow: hidden;""></textarea>

        <input type=""text"" class=""form-control"" name=""Description""
               oninvalid=""this.setCustomValidity('لطفا پیش از ارسال، توضیحات را کامل نمایید')""
               oninput=""this.setCustomValidity('')"" />

        <button data-role=""button"" type=""submit"" class=""btn btn-block m-t-xs"">");
                    EndContext();
                    BeginContext(1443, 12, false);
#line 30 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
                                                                         Write(Model.Action);

#line default
#line hidden
                    EndContext();
                    BeginContext(1455, 15, true);
                    WriteLiteral("</button>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1477, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 610, "Routine_Action_", 610, 15, true);
#line 16 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
AddHtmlAttributeValue("", 625, Model.Action, 625, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 640, "_", 640, 1, true);
#line 16 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
AddHtmlAttributeValue("", 641, Model.EntityId, 641, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1485, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Internship.Core.DomainModels.ViewModel.Routine2.Routine2ChangeStep> Html { get; private set; }
    }
}
#pragma warning restore 1591