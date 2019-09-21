using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Core.DomainModels.DTO.OfficialLetterTemplate
{
    public class OfficialLetterTemplateDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CreatorUserId { get; set; }
        public int UpdaterUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Key { get; set; }
        public int RoutineId { get; set; }
        public string Body { get; set; }
        public string SignatureName { get; set; }
        public string SignaturePost { get; set; }
        public string SignatureSign { get; set; }

        public string SerialCode { get; set; }
        public string SerialType { get; set; }
        public string Email { get; set; }

        public int ToUserId { get; set; }
        public int? SubSystemType { get; set; }
        public int? SubSystemId { get; set; }
        public bool HasAttachment { get; set; }
    }
}
