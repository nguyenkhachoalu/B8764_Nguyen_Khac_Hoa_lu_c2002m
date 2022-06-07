using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Model
{
    public class Bill
    {
        public int Id { get; set; }
        public int Id_Auction { get; set; }
        public DateTime CreateDate { get; set; }
        //Foreign Key
        public Auction auction    { get; set; }
    }
}
