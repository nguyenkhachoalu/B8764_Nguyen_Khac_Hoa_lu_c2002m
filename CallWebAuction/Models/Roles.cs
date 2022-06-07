using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallWebAuction.Models
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        //Foreign Key
        public ICollection<User> users { get; set; }
    }
}
