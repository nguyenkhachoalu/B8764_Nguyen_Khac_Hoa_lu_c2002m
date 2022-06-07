using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Model
{
    public class Auction
    {
        public int Id { get; set; }
        public int Id_Product { get; set; }
        public DateTime CreatTime { get; set; }
        public DateTime StartedDate { get; set; }
        public DateTime EndTime { get; set; }
        public float Top_Price { get; set; }
        public Guid? Top_User { get; set; }
        public bool Status { get; set; }

        //Foregin Key
        public ICollection<Bill> bills  { get; set; }
        public Product product { get; set; }
        public User user { get; set; }
    }
}
