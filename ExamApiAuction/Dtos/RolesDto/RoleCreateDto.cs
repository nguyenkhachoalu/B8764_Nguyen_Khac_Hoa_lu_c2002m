using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Dtos.RolesDto
{
    public class RoleCreateDto
    {
        [Required]
        public string Name { get; set; }
    }
}
