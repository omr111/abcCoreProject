using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class supply
    {
        public int Id { get; set; }
        public int supplierId { get; set; }
        public supplier supplier { get; set; }
        public DateTime? supplyDate { get; set; }
        public bool isActive { get; set; }
        public List<supplyDetail>   supplyDetails { get; set; }

    }

}
