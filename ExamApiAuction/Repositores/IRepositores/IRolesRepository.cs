using ExamApiAuction.Dtos.RolesDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores.IRepositores
{
    public interface IRolesRepository
    {
        Task<IEnumerable<RolesReadDto>> GetRolesAsync(CancellationToken cancellationToken);
        Task<Roles> GetRoleById(int id, CancellationToken cancellationToken);
        Task AddRole(Roles role,CancellationToken cancellationToken);
        void UpdateRole(Roles role);
        void DeleteRole(Roles role);
        void Savechange();
    }
}
