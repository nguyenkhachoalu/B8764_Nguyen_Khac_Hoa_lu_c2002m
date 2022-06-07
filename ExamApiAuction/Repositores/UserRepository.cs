using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExamApiAuction.Dtos.UserDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores
{
    public class UserRepository : IUserRepository
    {
        private AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public UserRepository(AppDbContext appDbContext, IMapper mapper)
        {
            _appDbContext = appDbContext;
            _mapper = mapper;
        }
        public async Task AddUser(User user, CancellationToken cancellationToken)
        {
            await _appDbContext.Users.AddAsync(user, cancellationToken);
        }

        public void DeleteUser(User user)
        {
            _appDbContext.Users.Remove(user);
        }

        public async Task<User> GetUserById(Guid id, CancellationToken cancellationToken)
        {
            return await _appDbContext.Users.Include("roles").AsNoTracking().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task<User> GetUserByUserName(string userName, CancellationToken cancellationToken)
        {
            return await _appDbContext.Users.Include("roles").FirstOrDefaultAsync(x => x.UserName.Equals(userName));
        }

        public async Task<IEnumerable<UserReadDto>> GetUsersAsync(CancellationToken cancellationToken)
        {
            return await _appDbContext.Users.Include("roles").ProjectTo<UserReadDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
        }

        public void Savechange()
        {
            _appDbContext.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _appDbContext.Users.Update(user);
        }
    }
}
