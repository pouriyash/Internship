using System;


namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestCreateViewModel
    {
        public string Title { get; set; }



        public int? OwnerUserId { get; set; }


        //public int RoutineStep { get; set; } = ForestRoutine.FirstStep;
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}
