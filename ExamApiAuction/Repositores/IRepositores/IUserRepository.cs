using ExamApiAuction.Dtos.UserDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Repositores.IRepositores
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserReadDto>> GetUsersAsync(CancellationToken cancellationToken);
        Task<User> GetUserById(Guid id, CancellationToken cancellationToken);
        Task AddUser(User user, CancellationToken cancellationToken);
        void UpdateUser(User user);
        void DeleteUser(User user );
        Task<User> GetUserByUserName(string userName, CancellationToken cancellationToken);
        void Savechange();
    }
}
