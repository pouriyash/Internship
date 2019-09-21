using System;


namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestEditUniversityViewModel
    {
        public string UniversityIdsJson { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
