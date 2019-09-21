using System.Collections.Generic;
using Internship.Core.DomainModels.Entity.Identity;
using cloudscribe.Web.Pagination;

namespace Internship.Core.DomainModels.ViewModel.Identity
{
    public class PagedUsersListViewModel: PaginationSettings
    { 

        public int? Id { get; set; }

        public string DisplayName { get; set; }

        public string UserName { get; set; }
        public List<User> Users { get; set; }

        public List<Role> Roles { get; set; }

    }
}
