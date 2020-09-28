namespace Entities.Concrete
{
    public class userRole
    {
        public int userId { get; set; }
        public int roleId { get; set; }
        public user user { get; set; }
        public role role { get; set; }

    }

}
