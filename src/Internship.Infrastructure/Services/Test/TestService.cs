using Alamut.Data.Linq;
using Alamut.Data.Paging;
using Alamut.Data.Sql;
using Alamut.Data.Structure;
using Alamut.Helpers.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Internship.Core.DomainModels.DTO.Routine2;
using Internship.Core.DomainModels.DTO.Test;
using Internship.Core.DomainModels.SSOT;
using Internship.Core.DomainModels.ViewModel.Routine2;
using Internship.Core.DomainModels.ViewModel.Test;
using Internship.Infrastructure.DataLayer.Context;
using Internship.Infrastructure.Services.Routine2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship.Infrastructure.Services.Test
{
    public class TestService
    {
        private readonly ApplicationDbContext _context;
        private readonly Routine2Repository _routine2Repository;

        public TestService(Routine2Repository routine2Repository, ApplicationDbContext context)
        {
            _context = context;
            _routine2Repository = routine2Repository;

        }
         
        public int Create(string title)
        {
            var entity = new Core.Entity.Internship.Test()
            {
                RoutineIsFlown = true,
                RoutineFlownDate = DateTime.Now,
                RoutineStep = 101,
                RoutineStepChangeDate = DateTime.Now,
                Title = title
            };
            _context.Test.Add(entity);
            _context.SaveChanges();
            return entity.Id;
        }

        public async Task<ServiceResult<Routine2ChangeStepResult>> ChangeStep(int id, Routine2Actions action, string description, int userId)
        {
            try
            {
                var entity = _context.Test.FirstOrDefault(q => q.Id == id);
                if (entity == null)
                    throw new Exception($"داده‌ای با شناسه {id} یافت نشد");

                var nextStep = GetNextStep(id, action);
                if (nextStep == -1)
                    throw new Exception("Something went wrong, next dashboard couldn't be -1");


                var fromStep = entity.RoutineStep;

                _routine2Repository.CreateLog(new CreateRoutine2LogViewModel
                {
                    RoutineId = TestRoutine.RoutineId,
                    EntityId = id,
                    Description = description,
                    Action = _routine2Repository.GetActionTitle(TestRoutine.RoutineId, fromStep, action),
                    Step = fromStep,
                    ToStep = nextStep,
                    UserId = userId,
                    CreatorUserId = userId,
                    RoutineRoleTitle = _routine2Repository.GetRoutineRoleTitle(TestRoutine.RoutineId, entity.RoutineStep),
                });

                var routineVm = new EditRoutine2ViewModel(nextStep, entity.RoutineFlownDate);
                 // اگر در مرحله آخر باشیم، باید به روال برچست تمام شده بزنیم
                if (TestRoutine.DoneSteps.Contains(nextStep))
                    routineVm.RoutineIsDone = true;

                // به صورت پیش‌فرض طرح رد شده است، مگر اینکه در مراحل تایید باشیم
                if (TestRoutine.SucceededSteps.Contains(nextStep))
                {
                    routineVm.RoutineIsSucceeded = true;
                }

                Mapper.Map(routineVm, entity);
                _context.SaveChanges();

                var changeStepResult = new Routine2ChangeStepResult
                {
                    Action = action,
                    Description = description,
                    UserId = userId,
                    ToStep = nextStep,
                    FromStep = fromStep,
                    EntityId = entity.Id,
                    RoutineId = TestRoutine.RoutineId,
                };

                //try { await _routine2Repository.SendNoticeAsync(changeStepResult); } catch (Exception ex) { }

                return ServiceResult<Routine2ChangeStepResult>.Okay(changeStepResult);
            }
            catch (Exception ex)
            {
                return ServiceResult<Routine2ChangeStepResult>.Exception(ex);
            }
        }

        public int GetNextStep(int id, Routine2Actions action)
        {
            var entity = _context.Test
                .AsNoTracking()
                .FirstOrDefault(q => q.Id == id);

            if (entity == null)
                throw new Exception($"داده‌ای با شناسه {id} یافت نشد");

            var currentStep = _routine2Repository.GetStep(TestRoutine.RoutineId, entity.RoutineStep);

            int? nextStep = null;

            switch (action)
            {
                case Routine2Actions.F1:
                    nextStep = currentStep.F1;
                    break;
                case Routine2Actions.F2:
                    nextStep = currentStep.F2;
                    break;
                case Routine2Actions.F3:
                    nextStep = currentStep.F3;
                    break;
                case Routine2Actions.F4:
                    nextStep = currentStep.F4;
                    break;
                case Routine2Actions.F5:
                    nextStep = currentStep.F5;
                    break;
                case Routine2Actions.F6:
                    nextStep = currentStep.F6;
                    break;
                case Routine2Actions.F7:
                    nextStep = currentStep.F7;
                    break;
            }

            return nextStep ?? -1;
        }

        #region گرفتن اطلاعات برای کارتابل‌ها : GetData
        public List<TestSummeryDTO> GetData(TestSearchCriteriaViewModel searchCriteria, int currPage = 1, int pageSize = 10)
        {
            var model = _context.Test.AsNoTracking();

            model = model.Where(q => q.RoutineIsFlown == searchCriteria.RoutineIsFlown);

            model = model.WhereIf(searchCriteria.RoutineIsDone.HasValue,
                q => q.RoutineIsDone == searchCriteria.RoutineIsDone);

            // تازه‌ها
            model = model.WhereIf(searchCriteria.DashboardType == DashboardTypes.New,
                q => searchCriteria.RoutineStepList.Contains(q.RoutineStep));

            // ارسال شده ها
            model = model.WhereIf(searchCriteria.DashboardType == DashboardTypes.Archived,
                q => searchCriteria.RoutineLogList.Contains(q.Id) &&
                !searchCriteria.RoutineStepList.Contains(q.RoutineStep));

            // خاتمه یافته ها
            model = model.WhereIf(searchCriteria.DashboardType == DashboardTypes.Done,
                q => searchCriteria.RoutineLogList.Contains(q.Id) &&
                TestRoutine.DoneSteps.Contains(q.RoutineStep));


            //model = model.WhereIf(searchCriteria.DashboardType == DashboardTypes.Draft,
            //    q => q.UserId == searchCriteria.UserId);

            model = model.WhereIf(searchCriteria.Step.HasValue,
                q => q.RoutineStep == searchCriteria.Step.Value);
             
            model = searchCriteria.DashboardType == DashboardTypes.New
                ? model.OrderBy(q => q.RoutineStepChangeDate)
                : model.OrderByDescending(q => q.RoutineStepChangeDate);

            return model.ProjectTo<TestSummeryDTO>().ToList();
        }
        #endregion




    }
}
