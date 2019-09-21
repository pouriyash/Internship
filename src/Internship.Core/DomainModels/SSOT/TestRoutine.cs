using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Internship.Core.DomainModels.SSOT
{
     
    public class TestRoutine
    {
        public static int RoutineId { get; set; } = 1000;
        public static int FirstStep { get; set; } = 101;

        public static List<int> DoneSteps { get; set; } = new List<int> {401 };
        public static List<int> SucceededSteps { get; set; } = new List<int> { 401};
    }

    public enum TestDashboard
    {
        [Display(Name = "متقاضی")]
        Applicant,

        [Display(Name = "کارتابل کارشناس دفتر استانی")]
        Expert,

        [Display(Name = "رئیس کمیته معارف استانی")]
        RelagiousCommittee,
         
    }
}
