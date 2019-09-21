using Internship.Core.Interface;
using System;
using System.Collections.Generic;

namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestSearchCriteriaViewModel : Routine2SearchCriteria
    {
        public int? OwnerUserId { get; set; }
        public int? UniversityId { get; set; }
        public string Title { get; set; }



    }
}
