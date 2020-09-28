using System.Collections.Generic;

namespace Entities.Concrete
{
    public class supplier
    {
        public supplier()
        {
            supplies = new List<supply>();

        }
        public int Id { get; set; }
        public string supplierName { get; set; }
        public string taxNumber { get; set; }

        public List<supply> supplies { get; set; }

    }

}
