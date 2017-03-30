using System.Collections.Generic;

namespace Server.Models
{
    public class ApplicationUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual IEnumerable<Role> Roles { get; set; }
    }
}