using System.ComponentModel;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Internship.Infrastructure.Services.Identity;
using Internship.Core.Common.IdentityToolkit;

namespace Internship.Web.Controllers
{
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [DisplayName("خانه")]
    [BreadCrumb(Title = "خانه", UseDefaultRouteUrl = true, Order = 0)]
    public class GeneralRoutine2Controller : Controller
    {
       
    }
}