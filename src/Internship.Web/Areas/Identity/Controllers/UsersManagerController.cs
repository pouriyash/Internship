using Internship.Core.Common.GuardToolkit;
using Internship.Core.Common.IdentityToolkit;
using Internship.Core.DomainModels.Entity.Identity;


using Internship.Core.DomainModels.ViewModel.Identity;
using DNTBreadCrumb.Core;
using DNTCommon.Web.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Internship.Infrastructure.Services.Identity;
using Internship.Infrastructure.Services.Contracts.Identity;
using System;

namespace Internship.Web.Areas.Identity.Controllers
{
    [Authorize(Roles = ConstantRoles.Admin)]
    [Area(AreaConstants.IdentityArea)]
    [BreadCrumb(Title = "مدیریت کاربران", UseDefaultRouteUrl = true, Order = 0)]
    public class UsersManagerController : Controller
    {
        private const int DefaultPageSize = 7;

        private readonly IApplicationRoleManager _roleManager;
        private readonly IApplicationUserManager _userManager;
        public UsersManagerController(
            IApplicationUserManager userManager,
            IApplicationRoleManager roleManager)
        {
            _userManager = userManager;
            _userManager.CheckArgumentIsNull(nameof(_userManager));

            _roleManager = roleManager;
            _roleManager.CheckArgumentIsNull(nameof(_roleManager));
        }

        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ActivateUserEmailStat(int userId)
        {
            User thisUser = null;
            var result = await _userManager.UpdateUserAndSecurityStampAsync(
                userId, user =>
                {
                    user.EmailConfirmed = true;
                    thisUser = user;
                });
            if (!result.Succeeded)
            {
                return BadRequest(error: result.DumpErrors(useHtmlNewLine: true));
            }

            return await returnUserCardPartialView(thisUser);
        }

        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ChangeUserLockoutMode(int userId, bool activate)
        {
            User thisUser = null;
            var result = await _userManager.UpdateUserAndSecurityStampAsync(
                userId, user =>
                {
                    user.LockoutEnabled = activate;
                    thisUser = user;
                });
            if (!result.Succeeded)
            {
                return BadRequest(error: result.DumpErrors(useHtmlNewLine: true));
            }

            return await returnUserCardPartialView(thisUser);
        }

        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ChangeUserRoles(int userId, int[] roleIds)
        {
            User thisUser = null;
            var result = await _userManager.AddOrUpdateUserRolesAsync(
                userId, roleIds, user => thisUser = user);
            if (!result.Succeeded)
            {
                return BadRequest(error: result.DumpErrors(useHtmlNewLine: true));
            }

            return await returnUserCardPartialView(thisUser);
        }

        
        public async Task<IActionResult> ChangeUserStat(int userId, bool activate)
        {
            User thisUser = null;
            var result = await _userManager.UpdateUserAndSecurityStampAsync(
                userId, user =>
                        {
                            user.IsActive = activate;
                            thisUser = user;
                        });
            if (!result.Succeeded)
            {
                return Json(false);
                //return BadRequest(error: result.DumpErrors(useHtmlNewLine: true));
            }

            return Json(true);

            //return await returnUserCardPartialView(thisUser);
        }

        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> ChangeUserTwoFactorAuthenticationStat(int userId, bool activate)
        {
            User thisUser = null;
            var result = await _userManager.UpdateUserAndSecurityStampAsync(
                userId, user =>
                {
                    user.TwoFactorEnabled = activate;
                    thisUser = user;
                });
            if (!result.Succeeded)
            {
                return BadRequest(error: result.DumpErrors(useHtmlNewLine: true));
            }

            return await returnUserCardPartialView(thisUser);
        }

        [AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> EndUserLockout(int userId)
        {
            User thisUser = null;
            var result = await _userManager.UpdateUserAndSecurityStampAsync(
                userId, user =>
                {
                    user.LockoutEnd = null;
                    thisUser = user;
                });
            if (!result.Succeeded)
            {
                return BadRequest(error: result.DumpErrors(useHtmlNewLine: true));
            }

            return await returnUserCardPartialView(thisUser);
        }

        [BreadCrumb(Title = "ایندکس", Order = 1)]
        public async Task<IActionResult> Index(PagedUsersListViewModel vm/*,int? page = 1, string field = "Id", SortOrder order = SortOrder.Ascending*/)
        {
            
            var model = await _userManager.GetPagedUsersListAsync(vm,showAllUsers: true);

            model.CurrentPage = vm.CurrentPage;
            model.ItemsPerPage = vm.ItemsPerPage;
            model.ShowFirstLast = true;

            if (HttpContext.Request.IsAjaxRequest())
            {
                return PartialView("_UsersList", model);
            }
            return View(model);
        }

        //[AjaxOnly, HttpPost, ValidateAntiForgeryToken]
        //[ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        //public async Task<IActionResult> SearchUsers(SearchUsersViewModel model)
        //{
        //    var pagedUsersList = await _userManager.GetPagedUsersListAsync(
        //        pageNumber: 0,
        //        model: model);

        //    pagedUsersList.Paging.CurrentPage = 1;
        //    pagedUsersList.Paging.ItemsPerPage = model.MaxNumberOfRows;
        //    pagedUsersList.Paging.ShowFirstLast = true;

        //    model.PagedUsersList = pagedUsersList;
        //    return PartialView("_SearchUsers", model);
        //}

        private async Task<IActionResult> returnUserCardPartialView(User thisUser)
        {
            var roles = await _roleManager.GetAllCustomRolesAsync();
            return PartialView(@"~/Areas/Identity/Views/UserCard/_UserCardItem.cshtml",
                new UserCardItemViewModel
                {
                    User = thisUser,
                    ShowAdminParts = true,
                    Roles = roles,
                    ActiveTab = UserCardItemActiveTab.UserAdmin
                });
        }

        
        public async Task<IActionResult> roleManage(SearchUsersViewModel model)
        {

            model.IsUserId = true;
            //var model = await _userManager.GetUserAsync();
            var pagedUsersList = await _userManager.GetPagedUsersListAsync(
               pageNumber: 0,
               model: model);



            return PartialView(pagedUsersList);
        }
    }
}