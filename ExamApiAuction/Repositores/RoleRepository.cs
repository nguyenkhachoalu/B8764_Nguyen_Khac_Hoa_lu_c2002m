using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExamApiAuction.Dtos.RolesDto;

namespace ExamApiAuction.Repositores
{
    public class RoleRepository : IRolesRepository
    {
        private AppDbContext _appDbContext;
        private IMapper _mapper;


        public RoleRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task AddRole(Roles role, CancellationToken cancellationToken)
        {
            await _appDbContext.Role.AddAsync(role, cancellationToken );
        }

        public void DeleteRole(Roles role)
        {
            _appDbContext.Role.Remove(role);
        }

        public async  Task<Roles> GetRoleById(int id, CancellationToken cancellationToken)
        {
            return await _appDbContext.Role.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            
        }

        public async Task<IEnumerable<RolesReadDto>> GetRolesAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Role.ProjectTo<RolesReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }

        public void UpdateRole(Roles role)
        {
            _appDbContext.Role.Update(role);
        }

        public void Savechange()
        {
             _appDbContext.SaveChanges();
        }

    }
}
