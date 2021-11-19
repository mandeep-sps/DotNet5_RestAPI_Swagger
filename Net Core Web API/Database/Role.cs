using System;
using System.Collections.Generic;

namespace Net_Core_Web_API.Database
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = null!;
        public bool IsActive { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
