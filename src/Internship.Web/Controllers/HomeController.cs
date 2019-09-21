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
    public class HomeController : Controller
    {
        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public IActionResult Index()
        {
            return View();
        }

        [BreadCrumb(Title = "خطا", Order = 1)]
        public IActionResult Error()
        {
            return View();
        }

        [BreadCrumb(Title = "اکشن تستی 1", Order = 2)]
        [DisplayName("اکشن تستی 1")]
        public IActionResult Test1()
        {
            return View();
        }
        
        [BreadCrumb(Title = "اکشن تستی ۳", Order =3)]
        [DisplayName("اکشن تستی 2")]
        public IActionResult Test2()
        {
            return View();
        }
        
        /// <summary>
        /// To test automatic challenge after redirecting from another site
        /// Sample URL: http://localhost:5000/Home/CallBackResult?token=1&status=2&orderId=3&terminalNo=4&rrn=5
        /// </summary>
        [Authorize]
        public IActionResult CallBackResult(long token, string status, string orderId, string terminalNo, string rrn)
        {
            var userId = User.Identity.GetUserId();
            return Json(new { userId, token, status, orderId, terminalNo, rrn });
        }
    }
}