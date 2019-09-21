using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Internship.Core.Entity.Internship
{
    /// <summary>
    ///سرشاخه کارآموزی
    /// </summary>
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "عنوان")]
        public string Title { get; set; }
        
        #region Relations

        public virtual ICollection<InternshipCenter>  internshipCenters { get; set; }
        #endregion 
    }
}