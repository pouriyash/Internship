#pragma checksum "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa49534c50db8162538d5b8b2d3191c566f9db4"
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
#line 1 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 6 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 7 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 8 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 9 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 10 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 11 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 12 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 13 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Infrastructure.DataLayer.Context;

#line default
#line hidden
#line 14 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.AuditableEntity;

#line default
#line hidden
#line 1 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
using Internship.Core.DomainModels.SSOT;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa49534c50db8162538d5b8b2d3191c566f9db4", @"/Views/Shared/_Routine2/_ChangeStep.cshtml")]
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
            BeginContext(117, 9, true);
            WriteLiteral("\r\n\r\n<span");
            EndContext();
            BeginWriteAttribute("title", " title=\"", 126, "\"", 147, 1);
#line 5 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 134, Model.Action, 134, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(148, 31, true);
            WriteLiteral(" \r\n      style=\"display: none;\"");
            EndContext();
            BeginWriteAttribute("id", "\r\n      id=\"", 179, "\"", 252, 4);
            WriteAttributeValue("", 191, "routine_record_action_tooltip_", 191, 30, true);
#line 7 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 221, Model.Action, 221, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 236, "_", 236, 1, true);
#line 7 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 237, Model.EntityId, 237, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(253, 28, true);
            WriteLiteral(">\r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", "\r\n            id=\"", 281, "\"", 352, 4);
            WriteAttributeValue("", 299, "routine_record_action_", 299, 22, true);
#line 9 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 321, Model.Action, 321, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 336, "_", 336, 1, true);
#line 9 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 337, Model.EntityId, 337, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(353, 43, true);
            WriteLiteral("\r\n            data-popover=\"Routine_Action_");
            EndContext();
            BeginContext(398, 12, false);
#line 10 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
                                     Write(Model.Action);

#line default
#line hidden
            EndContext();
            BeginContext(411, 1, true);
            WriteLiteral("_");
            EndContext();
            BeginContext(413, 14, false);
#line 10 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
                                                    Write(Model.EntityId);

#line default
#line hidden
            EndContext();
            BeginContext(427, 150, true);
            WriteLiteral("\"\r\n            class=\"exir--transparent-btn\"\r\n            >\r\n        <i data-role=\"icon\" class=\"pe-7s-play largeicon\"></i>\r\n    </button>\r\n</span>\r\n\r\n");
            EndContext();
            BeginContext(577, 912, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaa49534c50db8162538d5b8b2d3191c566f9db49090", async() => {
                BeginContext(662, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(668, 813, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaa49534c50db8162538d5b8b2d3191c566f9db49475", async() => {
                    BeginContext(704, 40, true);
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 744, "\"", 767, 1);
#line 19 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 752, Model.EntityId, 752, 15, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(768, 47, true);
                    WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Action\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 815, "\"", 836, 1);
#line 20 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
WriteAttributeValue("", 823, Model.Action, 823, 13, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(837, 609, true);
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
                    BeginContext(1447, 12, false);
#line 31 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
                                                                         Write(Model.Action);

#line default
#line hidden
                    EndContext();
                    BeginContext(1459, 15, true);
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
                BeginContext(1481, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 614, "Routine_Action_", 614, 15, true);
#line 17 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
AddHtmlAttributeValue("", 629, Model.Action, 629, 15, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 644, "_", 644, 1, true);
#line 17 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_ChangeStep.cshtml"
AddHtmlAttributeValue("", 645, Model.EntityId, 645, 15, false);

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
            BeginContext(1489, 4, true);
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