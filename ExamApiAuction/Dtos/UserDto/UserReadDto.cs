using ExamApiAuction.Dtos.RolesDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Dtos.UserDto
{
    public class UserReadDto
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
        public RolesReadDto roles { get; set; }
    }
}
