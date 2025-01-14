﻿
using DNTBreadCrumb.Core;
using DNTCaptcha.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using System;

using DNTPersianUtils.Core;
using DNTCommon.Web.Core;
using Internship.Infrastructure.Services.Contracts.Identity;
using Internship.Core.DomainModels.Entity.Identity;

using Internship.Core.Common.GuardToolkit;
using Internship.Core.Common.IdentityToolkit;

using Internship.Core.DomainModels.ViewModel.Identity.Emails;
using Internship.Core.DomainModels.ViewModel.Identity.Settings;
using Internship.Core.DomainModels.ViewModel.Identity;

namespace Internship.Web.Areas.Identity.Controllers
{
    [Area(AreaConstants.IdentityArea)]
    [AllowAnonymous]
    [BreadCrumb(Title = "بازیابی کلمه‌ی عبور", UseDefaultRouteUrl = true, Order = 0)]
    public class ForgotPasswordController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly IApplicationUserManager _userManager;
        private readonly IPasswordValidator<User> _passwordValidator;
        private readonly IOptionsSnapshot<SiteSettings> _siteOptions;

        public ForgotPasswordController(
            IApplicationUserManager userManager,
            IPasswordValidator<User> passwordValidator,
            IEmailSender emailSender,
            IOptionsSnapshot<SiteSettings> siteOptions)
        {
            _userManager = userManager;
            _userManager.CheckArgumentIsNull(nameof(_userManager));

            _passwordValidator = passwordValidator;
            _passwordValidator.CheckArgumentIsNull(nameof(_passwordValidator));

            _emailSender = emailSender;
            _emailSender.CheckArgumentIsNull(nameof(_emailSender));

            _siteOptions = siteOptions;
            _siteOptions.CheckArgumentIsNull(nameof(_siteOptions));
        }

        [BreadCrumb(Title = "تائید کلمه‌ی عبور فراموش شده", Order = 1)]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// For [Remote] validation
        /// </summary>
        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ValidatePassword(string password, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return Json("ایمیل وارد شده معتبر نیست.");
            }

            var result = await _passwordValidator.ValidateAsync(
                (UserManager<User>)_userManager, user, password);
            return Json(result.Succeeded ? "true" : result.DumpErrors(useHtmlNewLine: true));
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [ValidateDNTCaptcha(CaptchaGeneratorLanguage = DNTCaptcha.Core.Providers.Language.Persian)]
        public async Task<IActionResult> Index(ForgotPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null || !await _userManager.IsEmailConfirmedAsync(user))
                {
                    return View("Error");
                }

                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                await _emailSender.SendEmailAsync(
                   email: model.Email,
                   subject: "بازیابی کلمه‌ی عبور",
                   viewNameOrPath: "~/Areas/Identity/Views/EmailTemplates/_PasswordReset.cshtml",
                   model: new PasswordResetViewModel
                   {
                       UserId = user.Id,
                       Token = code,
                       EmailSignature = _siteOptions.Value.Smtp.FromName,
                       MessageDateTime = DateTime.UtcNow.ToLongPersianDateTimeString()
                   })
                    ;

                return View("ForgotPasswordConfirmation");
            }
            return View(model);
        }

        [BreadCrumb(Title = "تغییر کلمه‌ی عبور", Order = 1)]
        public IActionResult ResetPassword(string code = null)
        {
            return code == null ? View("Error") : View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                // Don't reveal that the user does not exist
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }

            var result = await _userManager.ResetPasswordAsync(user, model.Code, model.Password);
            if (result.Succeeded)
            {
                return RedirectToAction(nameof(ResetPasswordConfirmation));
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }

        [BreadCrumb(Title = "تائیدیه تغییر کلمه‌ی عبور", Order = 1)]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
    }
}