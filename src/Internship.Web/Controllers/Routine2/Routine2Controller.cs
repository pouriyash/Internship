using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alamut.Utilities.Http;
using Internship.AppService.Helpers;
using Internship.Core.Common.IdentityToolkit;
using Internship.Core.DomainModels.DTO.Routine2;
using Internship.Core.DomainModels.SSOT;
using Internship.Infrastructure.Services.Routine2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 
using Newtonsoft.Json; 

namespace Nahad.Admin.Controllers
{
    public class Routine2Controller : Controller
    {
        private readonly Routine2Repository _routine2Repository;  
        private readonly IUserResolverService _userResolverService;
        private readonly IHttpContextAccessor _contextAccessor;

        public Routine2Controller(Routine2Repository routinRepository
            , IUserResolverService userResolverService, IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
            _routine2Repository = routinRepository;
            _userResolverService = userResolverService;
        }

        public IActionResult GetLogs(string routineIdE, string entityIdE)
        {
            var entityId = Convert.ToInt32(AESGCM.SimpleDecryptWithPassword(entityIdE, AppConfiguration.EncryptionSalt));
            var routineId = Convert.ToInt32(AESGCM.SimpleDecryptWithPassword(routineIdE, AppConfiguration.EncryptionSalt));

            var model = _routine2Repository.GetLogs(routineId, entityId);
            ViewBag.RoutineId = routineId;
            return View(model);
        }

        public IActionResult GetRoutineStepsByRoutineId(int routineId)
        {
            var model = _routine2Repository.GetRoutineStepsByRoutineId(routineId);
            return Json(model);
        }

        public IActionResult GetRoutine(int routineId)
        {
            var model = _routine2Repository.GetRoutineFull(routineId);
            return Json(model);
        }


        /// <summary>
        /// ارسال
        /// Notice, SMS, Email
        /// برای تست در همه روال‌ها
        /// </summary>
        //public async Task<IActionResult> SendNotice(int RoutineId, int EntityId, int FromStep, int ToStep, bool realSend = false)
        //{
        //    var Params = new
        //    {
        //        RoutineId,
        //        EntityId,
        //        FromStep,
        //        ToStep,
        //    };

        //    var userId = _contextAccessor.HttpContext.User.Identity.GetUserId();

        //    try
        //    {
        //        var Result = await _routine2Repository.SendNoticeAsync(new Routine2ChangeStepResult
        //        {
        //            RoutineId = RoutineId,
        //            EntityId = EntityId,
        //            FromStep = FromStep,
        //            ToStep = ToStep,
        //            UserId = userId,
        //        }, realSend);

        //        return Json(new { Params, Result });
        //    }
        //    catch (Exception ex)
        //    {
        //        return Json(new { Params, ex.Message });
        //    }
        //}


        //public IActionResult Autodash()
        //{
        //    _routine2Repository.Authodash();
        //    return Content("DONE Authodash");
        //}

        //public IActionResult Reminder()
        //{
        //    _routine2Repository.Reminder();
        //    return Content("DONE Reminder");
        //}
    }
}