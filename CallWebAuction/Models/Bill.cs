using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallWebAuction.Models
{
    public class Bill
    {
        public int Id { get; set; }
        public int Id_Auction { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
