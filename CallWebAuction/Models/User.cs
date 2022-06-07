using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CallWebAuction.Models
{
    public class User
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public float Coin { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        public int Id_Roles { get; set; }
        [Required]
        public bool Incognito { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public RolesReadDto roles { get; set; }
    }
}
