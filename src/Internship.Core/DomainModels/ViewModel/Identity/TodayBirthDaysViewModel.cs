using System.Collections.Generic;
using Internship.Core.DomainModels.ViewModel.Identity;
using Internship.Core.DomainModels.Entity.Identity;

namespace Internship.Core.DomainModels.ViewModel.Identity
{
    public class TodayBirthDaysViewModel
    {
        public List<User> Users { set; get; }

        public AgeStatViewModel AgeStat { set; get; }
    }
}