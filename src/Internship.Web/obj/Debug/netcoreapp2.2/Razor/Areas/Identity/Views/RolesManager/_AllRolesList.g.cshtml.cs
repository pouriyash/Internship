#pragma checksum "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "874d2e9c0f2f3bd42b3fba9d8ac245510bcf277c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_RolesManager__AllRolesList), @"mvc.1.0.view", @"/Areas/Identity/Views/RolesManager/_AllRolesList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/RolesManager/_AllRolesList.cshtml", typeof(AspNetCore.Areas_Identity_Views_RolesManager__AllRolesList))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts;

#line default
#line hidden
#line 7 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 8 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Emails;

#line default
#line hidden
#line 9 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 10 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 11 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 12 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 13 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 14 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 15 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 16 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Infrastructure.Services.Contracts.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"874d2e9c0f2f3bd42b3fba9d8ac245510bcf277c", @"/Areas/Identity/Views/RolesManager/_AllRolesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8855e927cc29baffb9e09864cdbecda77e26a913", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_RolesManager__AllRolesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleAndUsersCountViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UsersInRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DynamicRoleClaimsManager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(50, 1753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874d2e9c0f2f3bd42b3fba9d8ac245510bcf277c8253", async() => {
                BeginContext(80, 432, true);
                WriteLiteral(@"
  <table id=""all-roles-list"" class=""table table-striped table-hover table-bordered"">
   <thead class=""thead-light"">
    <tr>
        <th class=""text-center"">نام نقش</th>
        <th class=""text-center"">تعداد اعضاء</th>
        <th class=""text-center"">مدیریت نقش</th>
        <th class=""text-center"">مدیریت اعضای نقش</th>
        <th class=""text-center"">مدیریت دسترسی‌های پویای نقش</th>
    </tr>
   </thead>
   <tbody>
");
                EndContext();
#line 15 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
     if (!Model.Any())
            {

#line default
#line hidden
                BeginContext(551, 97, true);
                WriteLiteral("        <tr>\r\n            <td colspan=\"5\" class=\"text-center\">نقشی یافت نشد</td>\r\n        </tr>\r\n");
                EndContext();
#line 20 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
    }
    else
    {
        foreach (var item in Model)
        {
            var role = item.Role;

#line default
#line hidden
                BeginContext(755, 58, true);
                WriteLiteral("            <tr>\r\n                <td class=\"text-center\">");
                EndContext();
                BeginContext(814, 9, false);
#line 27 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
                                   Write(role.Name);

#line default
#line hidden
                EndContext();
                BeginContext(823, 47, true);
                WriteLiteral("</td>\r\n                <td class=\"text-center\">");
                EndContext();
                BeginContext(871, 15, false);
#line 28 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
                                   Write(item.UsersCount);

#line default
#line hidden
                EndContext();
                BeginContext(886, 80, true);
                WriteLiteral("</td>\r\n                <td class=\"text-center\">\r\n                    <a href=\"#\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 966, "\"", 987, 2);
                WriteAttributeValue("", 971, "btnEdit-", 971, 8, true);
#line 30 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
WriteAttributeValue("", 979, role.Id, 979, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(988, 15, true);
                WriteLiteral(" data-edit-id=\"");
                EndContext();
                BeginContext(1004, 7, false);
#line 30 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
                                                               Write(role.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1011, 76, true);
                WriteLiteral("\" class=\"btn btn-sm btn-primary\">ویرایش</a>\r\n                    <a href=\"#\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 1087, "\"", 1110, 2);
                WriteAttributeValue("", 1092, "btnDelete-", 1092, 10, true);
#line 31 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
WriteAttributeValue("", 1102, role.Id, 1102, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1111, 17, true);
                WriteLiteral(" data-delete-id=\"");
                EndContext();
                BeginContext(1129, 7, false);
#line 31 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
                                                                   Write(role.Id);

#line default
#line hidden
                EndContext();
                BeginContext(1136, 126, true);
                WriteLiteral("\" class=\"btn btn-sm btn-danger\">حذف</a>\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
                EndContext();
                BeginContext(1262, 157, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874d2e9c0f2f3bd42b3fba9d8ac245510bcf277c13021", async() => {
                    BeginContext(1342, 73, true);
                    WriteLiteral("\r\n                        مشاهده و تغییر لیست اعضاء\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 34 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
                                                                              WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1419, 87, true);
                WriteLiteral("\r\n                </td>\r\n                <td class=\"text-center\">\r\n                    ");
                EndContext();
                BeginContext(1506, 206, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "874d2e9c0f2f3bd42b3fba9d8ac245510bcf277c15795", async() => {
                    BeginContext(1625, 83, true);
                    WriteLiteral("\r\n                        مشاهده و تغییر لیست دسترسی‌های پویا\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 39 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
                                                                                                                     WriteLiteral(role.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1712, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 44 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\RolesManager\_AllRolesList.cshtml"
        }
    }

#line default
#line hidden
                BeginContext(1774, 23, true);
                WriteLiteral("  </tbody>\r\n </table>\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleAndUsersCountViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
