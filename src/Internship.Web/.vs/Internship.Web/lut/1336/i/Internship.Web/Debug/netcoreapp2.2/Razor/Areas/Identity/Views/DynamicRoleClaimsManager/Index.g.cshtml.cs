#pragma checksum "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea9dfcd3ceb6a520c518fd948496fe339de286a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_DynamicRoleClaimsManager_Index), @"mvc.1.0.view", @"/Areas/Identity/Views/DynamicRoleClaimsManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/DynamicRoleClaimsManager/Index.cshtml", typeof(AspNetCore.Areas_Identity_Views_DynamicRoleClaimsManager_Index))]
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
#line 2 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
using Internship.Infrastructure.Services.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea9dfcd3ceb6a520c518fd948496fe339de286a4", @"/Areas/Identity/Views/DynamicRoleClaimsManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8855e927cc29baffb9e09864cdbecda77e26a913", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_DynamicRoleClaimsManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DynamicRoleClaimsManagerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DynamicRoleClaimsManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-begin", new global::Microsoft.AspNetCore.Html.HtmlString("dataAjaxBegin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-success", new global::Microsoft.AspNetCore.Html.HtmlString("dataAjaxSuccess"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax-failure", new global::Microsoft.AspNetCore.Html.HtmlString("dataAjaxFailure"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dynamicPermissions"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(94, 33, true);
            WriteLiteral("<h2>تنظیم سطوح دسترسی پویای نقش «");
            EndContext();
            BeginContext(128, 32, false);
#line 3 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                            Write(Model.RoleIncludeRoleClaims.Name);

#line default
#line hidden
            EndContext();
            BeginContext(160, 10, true);
            WriteLiteral("»</h2>\r\n\r\n");
            EndContext();
            BeginContext(170, 583, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9dfcd3ceb6a520c518fd948496fe339de286a410738", async() => {
                BeginContext(200, 547, true);
                WriteLiteral(@"
    <a href=""#"" class=""close"" data-dismiss=""alert"">×</a>
    <ul>
        <li>
            نقش ویژه‌ی Admin به تمام صفحات لیست شده‌ی در اینجا دسترسی کاملی دارد و هرگونه ویرایشی بر روی آن تاثیرگذار نخواهد بود.
        </li>
        <li>
            در اینجا می‌توان به هر نقش ثابت، دسترسی‌های پویایی را نیز اعطاء کرد. در این حالت کنترلر و یا اکشن متدهایی با پالیسی سطوح دسترسی پویا، لیست شده و قابل انتخاب خواهند بود
            <span dir=""ltr"">.([Authorize(Policy = ConstantPolicies.DynamicPermission)])</span>
        </li>
    </ul>
");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(753, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(757, 2523, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9dfcd3ceb6a520c518fd948496fe339de286a412576", async() => {
                BeginContext(786, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(792, 2480, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9dfcd3ceb6a520c518fd948496fe339de286a412963", async() => {
                    BeginContext(1083, 30, true);
                    WriteLiteral("\r\n        <input name=\"RoleId\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 1113, "\"", 1152, 1);
#line 27 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
WriteAttributeValue("", 1121, Model.RoleIncludeRoleClaims.Id, 1121, 31, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(1153, 19, true);
                    WriteLiteral(" type=\"hidden\" />\r\n");
                    EndContext();
#line 28 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
         foreach (var controller in Model.SecuredControllerActions.OrderBy(x => x.ControllerDisplayName))
        {

#line default
#line hidden
                    BeginContext(1290, 12, true);
                    WriteLiteral("            ");
                    EndContext();
                    BeginContext(1302, 1768, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9dfcd3ceb6a520c518fd948496fe339de286a414285", async() => {
                        BeginContext(1325, 18, true);
                        WriteLiteral("\r\n                ");
                        EndContext();
                        BeginContext(1343, 477, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea9dfcd3ceb6a520c518fd948496fe339de286a414726", async() => {
                            BeginContext(1368, 47, true);
                            WriteLiteral("\r\n                    <h5 class=\"card-title\">\r\n");
                            EndContext();
#line 33 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                          
                            var displayName = controller.ControllerDisplayName;
                            if(string.IsNullOrWhiteSpace(displayName))
                            {
                                displayName = controller.ToString();
                            }
                        

#line default
#line hidden
                            BeginContext(1755, 24, true);
                            WriteLiteral("                        ");
                            EndContext();
                            BeginContext(1780, 11, false);
#line 40 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                   Write(displayName);

#line default
#line hidden
                            EndContext();
                            BeginContext(1791, 23, true);
                            WriteLiteral("</h5>\r\n                ");
                            EndContext();
                        }
                        );
                        __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                        __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1820, 60, true);
                        WriteLiteral("\r\n                <ul class=\"list-group list-group-flush\">\r\n");
                        EndContext();
#line 43 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                     foreach (var action in controller.MvcActions.OrderBy(x => x.ActionDisplayName))
                    {
                        var isSelected = Model.RoleIncludeRoleClaims.Claims
                            .Any(roleClaim => roleClaim.ClaimType == ConstantPolicies.DynamicPermissionClaimType &&
                                              roleClaim.ClaimValue == action.ActionId);
                        var selected = isSelected ? "checked" : "";
                        var selectedClass = isSelected ? "list-group-item-success" : "";
                        var actionDisplayName = action.ActionDisplayName;
                        if(string.IsNullOrWhiteSpace(actionDisplayName))
                        {
                            actionDisplayName = $"{action}::{action.ActionId}";
                        }

#line default
#line hidden
                        BeginContext(2731, 27, true);
                        WriteLiteral("                        <li");
                        EndContext();
                        BeginWriteAttribute("class", " class=\"", 2758, "\"", 2796, 2);
                        WriteAttributeValue("", 2766, "list-group-item", 2766, 15, true);
#line 55 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
WriteAttributeValue(" ", 2781, selectedClass, 2782, 14, false);

#line default
#line hidden
                        EndWriteAttribute();
                        BeginContext(2797, 90, true);
                        WriteLiteral(" role=\"presentation\">\r\n                            <input type=\"checkbox\" name=\"actionIds\"");
                        EndContext();
                        BeginWriteAttribute("value", " value=\"", 2887, "\"", 2911, 1);
#line 56 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
WriteAttributeValue("", 2895, action.ActionId, 2895, 16, false);

#line default
#line hidden
                        EndWriteAttribute();
                        BeginContext(2912, 1, true);
                        WriteLiteral(" ");
                        EndContext();
                        BeginContext(2914, 8, false);
#line 56 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                                                                                        Write(selected);

#line default
#line hidden
                        EndContext();
                        BeginContext(2922, 33, true);
                        WriteLiteral(" />\r\n                            ");
                        EndContext();
                        BeginContext(2956, 17, false);
#line 57 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                       Write(actionDisplayName);

#line default
#line hidden
                        EndContext();
                        BeginContext(2973, 33, true);
                        WriteLiteral("\r\n                        </li>\r\n");
                        EndContext();
#line 59 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
                    }

#line default
#line hidden
                        BeginContext(3029, 35, true);
                        WriteLiteral("                </ul>\r\n            ");
                        EndContext();
                    }
                    );
                    __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3070, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 62 "I:\02\NewInternship\Internship.Web\Areas\Identity\Views\DynamicRoleClaimsManager\Index.cshtml"
        }

#line default
#line hidden
                    BeginContext(3083, 182, true);
                    WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-info top15\">\r\n            اعمال تغییرات\r\n            <span aria-hidden=\"true\" class=\"fas fa-thumbs-up\"></span>\r\n        </button>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3272, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3280, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3303, 432, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $('input[name=""actionIds""]').click(function () {
                if ($(this).is(':checked')) {
                    $(this).parent().addClass('list-group-item-success');
                } else {
                    $(this).parent().removeClass('list-group-item-success');
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DynamicRoleClaimsManagerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
