using System.ComponentModel.DataAnnotations;

namespace Internship.Web.DomainModel.ViewModels.InternshipCenter
{
    public class InternshipCenterViewModel
    {
        public string Title { get; set; }

        [Display(Name = "شناسه سرشاخه")]
        public int BranchId { get; set; }
    }
}