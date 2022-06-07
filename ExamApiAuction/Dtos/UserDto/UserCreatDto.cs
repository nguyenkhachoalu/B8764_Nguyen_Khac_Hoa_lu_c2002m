using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Dtos.UserDto
{
    public class UserCreatDto
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public float Coin { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Id_Roles { get; set; }
        public bool Incognito { get; set; }
    }
}
