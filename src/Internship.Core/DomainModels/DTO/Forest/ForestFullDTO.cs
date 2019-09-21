using System;
using System.Collections.Generic;
using System.Text;
using Internship.Core.DomainModels.DTO.User;

namespace Internship.Core.DomainModels.DTO.Forest
{
    public class ForestFullDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }
        public int? Score { get; set; }

        public int? OwnerUserId { get; set; }

        public string UniversityIdsJson { get; set; }

        public int RoutineStep { get; set; }
        public bool RoutineIsFlown { get; set; }
        public bool RoutineIsDone { get; set; }
        public DateTime? RoutineFlownDate { get; set; }
        public DateTime? RoutineStepChangeDate { get; set; }
        public bool RoutineIsSucceeded { get; set; }

        public virtual UserSummary OwnerUser { get; set; }

    }
}
