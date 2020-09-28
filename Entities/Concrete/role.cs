using System.Collections.Generic;

namespace Entities.Concrete
{
    public class role
    {
        public role()
        {
            userRoles = new List<userRole>();
        }
        public int Id { get; set; }
        public string roleName { get; set; }
        public List<userRole> userRoles { get; set; }

    }

}
