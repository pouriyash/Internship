using Internship.Core.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Core.DomainModels.DTO.Test
{
    public class TestSummeryDTO: IRoutine2Entity
    {
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
