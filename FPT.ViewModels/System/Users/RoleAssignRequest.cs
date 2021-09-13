using FPT.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace FPT.ViewModels.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}