using System.ComponentModel;
using DNTBreadCrumb.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Internship.Infrastructure.Services.Identity;
using Internship.Core.Common.IdentityToolkit;
using Internship.Core.DomainModels.SSOT;
using Internship.Infrastructure.Services.Test;
using Microsoft.AspNetCore.Http;
using Internship.Infrastructure.Services.Routine2;
using Internship.Core.DomainModels.DTO.Routine2;
using Internship.Core.DomainModels.ViewModel.Test;
using Alamut.Data.Paging;
using Internship.Core.DomainModels.DTO.Test;
using System;
using Internship.Core.Interface;
using Internship.Core.Entity.Internship;
using System.Collections.Generic;
using Internship.Web.Helpers;
using System.Threading.Tasks;

namespace Internship.Web.Controllers
{
    [Authorize(Policy = ConstantPolicies.DynamicPermission)]
    [BreadCrumb(Title = "روتین تستی", UseDefaultRouteUrl = true, Order = 0)]
    [DisplayName("روتین تستی")]
    public class TestController : Controller
    {
        private readonly TestService _testService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly Routine2Repository _routine2Repository;
 
        public TestController(TestService testService, IHttpContextAccessor contextAccessor, Routine2Repository routine2Repository)
        {
            _contextAccessor = contextAccessor;
            _testService = testService;
            _routine2Repository = routine2Repository;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title)
        {
            var id=_testService.Create(title);
            return RedirectToAction(nameof(Index));
        }

        [BreadCrumb(Title = "ایندکس", Order = 1)]
        [DisplayName("داشبورد")]
        public IActionResult Index()
        {
            return View();
        } 

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="S">searchCriteria</typeparam>
        //public void ManageMethod<S>() where S : Routine2SearchCriteria
        //{
        //    var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();

        //    // مراحل تازه‌های کارتابل فعلی چیست
        //    searchCriteria.RoutineStepList =
        //        _routine2Repository.GetRoleSteps(TestRoutine.RoutineId, currentDashboard.ToString());

        //    // کاربر در سمت فعلی، بر روی چه طرح‌هایی عملیاتی انجام داده است
        //    searchCriteria.RoutineLogList =
        //        _routine2Repository.GetUserEntityIds(TestRoutine.RoutineId, Convert.ToInt32(userId), currentDashboard.ToString());

        //    #region DashboardType: Draft, New, Archived, Done
        //    // پیش نویس‌ها
        //    if (searchCriteria.DashboardType == DashboardTypes.Draft)
        //        searchCriteria.RoutineIsFlown = false;

        //    if (searchCriteria.DashboardType == DashboardTypes.Done)
        //        searchCriteria.RoutineIsDone = true;
        //    #endregion


        //    var data = _testService.GetData(searchCriteria);

        //    var model = new Routine2PageModel<IPaginated<TestSummeryDTO>, TestSearchCriteriaViewModel, TestDashboard>(data, searchCriteria, currentDashboard);

        //    return View(model);
        //}

        [DisplayName("کارتابل مشتری")]
        [BreadCrumb(Title = "مشتری", Order = 2)]
        public IActionResult TestCustomer(TestSearchCriteriaViewModel searchCriteria, TestDashboard currentDashboard)
        {
            var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();

            // مراحل تازه‌های کارتابل فعلی چیست
            searchCriteria.RoutineStepList =
                _routine2Repository.GetRoleSteps(TestRoutine.RoutineId, currentDashboard.ToString());

            // کاربر در سمت فعلی، بر روی چه طرح‌هایی عملیاتی انجام داده است
            searchCriteria.RoutineLogList =
                _routine2Repository.GetUserEntityIds(TestRoutine.RoutineId, Convert.ToInt32(userId), currentDashboard.ToString());

            #region DashboardType: Draft, New, Archived, Done
            // پیش نویس‌ها
            if (searchCriteria.DashboardType == DashboardTypes.Draft)
                searchCriteria.RoutineIsFlown = false;

            if (searchCriteria.DashboardType == DashboardTypes.Done)
                searchCriteria.RoutineIsDone = true;
            #endregion


            var data = _testService.GetData(searchCriteria);

            var model = new Routine2PageModel<List<TestSummeryDTO>, TestSearchCriteriaViewModel, TestDashboard>(data, searchCriteria, currentDashboard);

            return View(model);
        }

        [DisplayName("کارتابل مدیر")]
        [BreadCrumb(Title = "مدیر", Order = 3)]
        public IActionResult TestManager(TestSearchCriteriaViewModel searchCriteria, TestDashboard currentDashboard)
        {
            var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();

            // مراحل تازه‌های کارتابل فعلی چیست
            searchCriteria.RoutineStepList =
                _routine2Repository.GetRoleSteps(TestRoutine.RoutineId, currentDashboard.ToString());

            // کاربر در سمت فعلی، بر روی چه طرح‌هایی عملیاتی انجام داده است
            searchCriteria.RoutineLogList =
                _routine2Repository.GetUserEntityIds(TestRoutine.RoutineId, Convert.ToInt32(userId), currentDashboard.ToString());

            #region DashboardType: Draft, New, Archived, Done
            // پیش نویس‌ها
            if (searchCriteria.DashboardType == DashboardTypes.Draft)
                searchCriteria.RoutineIsFlown = false;

            if (searchCriteria.DashboardType == DashboardTypes.Done)
                searchCriteria.RoutineIsDone = true;
            #endregion


            var data = _testService.GetData(searchCriteria);

            var model = new Routine2PageModel<List<TestSummeryDTO>, TestSearchCriteriaViewModel, TestDashboard>(data,searchCriteria, currentDashboard);

            return View(model);
        }

        [DisplayName("کارتابل کمیته معارف")]
        [BreadCrumb(Title = "کمیته معارف", Order = 4)]
        public IActionResult TestscienceCommitee(TestSearchCriteriaViewModel searchCriteria, TestDashboard currentDashboard)
        {
            var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();

            // مراحل تازه‌های کارتابل فعلی چیست
            searchCriteria.RoutineStepList =
                _routine2Repository.GetRoleSteps(TestRoutine.RoutineId, currentDashboard.ToString());

            // کاربر در سمت فعلی، بر روی چه طرح‌هایی عملیاتی انجام داده است
            searchCriteria.RoutineLogList =
                _routine2Repository.GetUserEntityIds(TestRoutine.RoutineId, Convert.ToInt32(userId), currentDashboard.ToString());

            #region DashboardType: Draft, New, Archived, Done
            // پیش نویس‌ها
            if (searchCriteria.DashboardType == DashboardTypes.Draft)
                searchCriteria.RoutineIsFlown = false;

            if (searchCriteria.DashboardType == DashboardTypes.Done)
                searchCriteria.RoutineIsDone = true;
            #endregion


            var data = _testService.GetData(searchCriteria);

            var model = new Routine2PageModel<List<TestSummeryDTO>, TestSearchCriteriaViewModel, TestDashboard>(data, searchCriteria, currentDashboard);

            return View(model);
        }

        public void Manage(TestSearchCriteriaViewModel searchCriteria, TestDashboard currentDashboard)
        {
            var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();

            // مراحل تازه‌های کارتابل فعلی چیست
            searchCriteria.RoutineStepList =
                _routine2Repository.GetRoleSteps(TestRoutine.RoutineId, currentDashboard.ToString());

            // کاربر در سمت فعلی، بر روی چه طرح‌هایی عملیاتی انجام داده است
            searchCriteria.RoutineLogList =
                _routine2Repository.GetUserEntityIds(TestRoutine.RoutineId, Convert.ToInt32(userId), currentDashboard.ToString());

            #region DashboardType: Draft, New, Archived, Done
            // پیش نویس‌ها
            if (searchCriteria.DashboardType == DashboardTypes.Draft)
                searchCriteria.RoutineIsFlown = false;

            if (searchCriteria.DashboardType == DashboardTypes.Done)
                searchCriteria.RoutineIsDone = true;
            #endregion


            var data = _testService.GetData(searchCriteria);

            var model = new Routine2PageModel<List<TestSummeryDTO>, TestSearchCriteriaViewModel, TestDashboard>(data, searchCriteria, currentDashboard);

            //return View(model);
        }

        public IActionResult Step101(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [HttpPost]
        public IActionResult Step101Next(int id)
        {
            return Routine2Helper.DoAction(id, Routine2Actions.F1, "ارسال تستی");
        }

        [HttpPost]
        public async Task<IActionResult> ChangeDashboard(int id, Routine2Actions action, string description = "")
        {
            var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();
            var result = await _testService.ChangeStep(id, action, description, Convert.ToInt32(userId));
            return Json(result);
        }
    }
}