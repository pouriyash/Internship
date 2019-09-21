﻿using Internship.Core.DomainModels.Entity.AuditableEntity;
using Microsoft.AspNetCore.Identity;

namespace Internship.Core.DomainModels.Entity.Identity
{
    
    public class RoleClaim : IdentityRoleClaim<int>, IAuditableEntity
    {
        public virtual Role Role { get; set; }
    }
}