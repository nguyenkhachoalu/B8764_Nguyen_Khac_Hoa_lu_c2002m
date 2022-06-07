 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Model
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public float Coin { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Id_Roles { get; set; }
        public bool Incognito { get; set; }
        public DateTime CreateDate { get; set; }

        //foreign Key
        public Roles roles { get; set; }
        public ICollection<Auction> auctions { get; set; }
    }
}
