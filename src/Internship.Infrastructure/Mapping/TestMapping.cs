using AutoMapper;
using Internship.Core.DomainModels.DTO.Test;
using Internship.Core.DomainModels.ViewModel.Routine2;
using Internship.Core.Entity.Internship;
using System;
using System.Collections.Generic;
using System.Text;

namespace Internship.Infrastructure.Mapping
{
    public class TestMapping:Profile
    {
        public TestMapping()
        { 
            CreateMap<Test, TestSummeryDTO>(); 
            CreateMap<EditRoutine2ViewModel, Test>().ReverseMap(); 
        }
    }
}
