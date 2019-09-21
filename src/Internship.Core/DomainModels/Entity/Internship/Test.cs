using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Internship.Core.Interface;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Internal;

namespace Internship.Core.Entity.Internship
{
    /// <summary>
    /// روتین تستی
    /// </summary>
    public class Test: IRoutine2Entity
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

    }
}