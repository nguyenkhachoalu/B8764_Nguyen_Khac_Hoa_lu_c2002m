using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Dtos.BillDto
{
    public class BillReadDto
    {
        public int Id { get; set; }
        public int Id_Auction { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
