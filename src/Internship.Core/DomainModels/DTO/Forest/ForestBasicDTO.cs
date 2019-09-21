using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.CoreDomainModels.DTO.Forest
{
    public class ForestBasicDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }



        public int RoutineStep { get; set; }
        public bool RoutineIsFlown { get; set; }
        public bool RoutineIsDone { get; set; }
        public DateTime? RoutineFlownDate { get; set; }
        public DateTime? RoutineStepChangeDate { get; set; }
        public bool RoutineIsSucceeded { get; set; }
    }
}
