using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Dtos.AuctionDto
{
    public class AuctionUpdateDto
    {
        public int Id_Product { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndTime { get; set; }
        public float Top_Price { get; set; }
        public Guid? Top_User { get; set; }
        public bool Status { get; set; }
    }
}
