
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class user
    {
        public user()
        {
            userRoles = new List<userRole>();
            orders = new List<order>();
        }
        public int Id { get; set; }
        public string userName { get; set; }
        public string userEmail { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public bool isActive { get; set; }
        public byte[] passwordHash { get; set; }
        public byte[] passwordSalt { get; set; }
        public string address { get; set; }
        public string profilePictureUrl { get; set; }
        public List<userRole> userRoles { get; set; }
        public List<order> orders { get; set; }
       

    }

}
