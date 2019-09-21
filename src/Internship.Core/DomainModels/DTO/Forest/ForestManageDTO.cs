
using Internship.Core.DomainModels.Entity.Routine2;
using Internship.Core.DomainModels.ViewModel.Forest;
using System.Collections.Generic;



namespace Internship.Core.DomainModels.DTO.Forest
{
    public class ForestManageDTO
    {
        public List<ForestSummary> Data { get; set; }
        public ForestSearchCriteriaViewModel SearchCriteria { get; set; }
        public Routine2Role CurrentRole { get; set; }
    }
}
