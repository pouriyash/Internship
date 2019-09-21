using System;


namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestEditDescriptionViewModel
    {
        public string Description { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
