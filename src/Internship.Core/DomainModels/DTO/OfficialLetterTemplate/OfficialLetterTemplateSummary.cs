using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Core.DomainModels.DTO.OfficialLetterTemplate
{
    public class OfficialLetterTemplateSummary
    {
        public int Id { get; set; }
        public int CreatorUserId { get; set; }
        public int UpdaterUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Key { get; set; }
        public int RoutineId { get; set; }
        public string SignatureName { get; set; }
        public string SignaturePost { get; set; }
        public string SignatureSign { get; set; }
        public string Title { get; set; }
    }
}
