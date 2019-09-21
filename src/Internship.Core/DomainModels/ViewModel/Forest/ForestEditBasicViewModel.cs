using System;


namespace Internship.Core.DomainModels.ViewModel.Forest
{
    public class ForestEditBasicViewModel
    {
        public string Title { get; set; }

        public DateTime UpdatedDate { get; set; } = DateTime.Now;
    }
}
