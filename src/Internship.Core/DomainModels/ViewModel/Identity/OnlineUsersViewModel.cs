using System.Collections.Generic;
using Internship.Core.DomainModels.Entity.Identity;

namespace Internship.Core.DomainModels.ViewModel.Identity
{
    public class OnlineUsersViewModel
    {
        public List<User> Users { set; get; }
        public int NumbersToTake { set; get; }
        public int MinutesToTake { set; get; }
        public bool ShowMoreItemsLink { set; get; }
    }
}