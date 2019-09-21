using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;

namespace Internship.Core.Entity.Internship
{
    /// <summary>
    /// مراکز کارآموزی
    /// </summary>
    public class InternshipCenter
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        [Display(Name = "شناسه سرشاخه")]
        public int BranchId { get; set; }
        
        #region Relations

        [ForeignKey(nameof(BranchId))]
        public virtual Branch Branch { get; set; }
        #endregion    
    }
}