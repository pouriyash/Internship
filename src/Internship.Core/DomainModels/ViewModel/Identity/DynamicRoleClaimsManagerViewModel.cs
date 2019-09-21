using System.Collections.Generic;
using Internship.Core.DomainModels.Entity.Identity;
using DNTCommon.Web.Core;

namespace Internship.Core.DomainModels.ViewModel.Identity
{
    public class DynamicRoleClaimsManagerViewModel
    {
        public string[] ActionIds { set; get; }

        public int RoleId { set; get; }

        public Role RoleIncludeRoleClaims { set; get; }

        public ICollection<MvcControllerViewModel> SecuredControllerActions { set; get; }
    }
}