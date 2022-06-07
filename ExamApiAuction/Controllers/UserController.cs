using AutoMapper;
using ExamApiAuction.Dtos.UserDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamApiAuction.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetUserAsync(CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetUsersAsync(cancellationToken);
            return await Task.FromResult(Ok(result));
        }
        
        [HttpGet("getbyid/{id}")]
        public async Task<IActionResult> GetUserByIdAsync(Guid id,CancellationToken cancellationToken)
        {
            var userResult = await _userRepository.GetUserById(id, cancellationToken);
            var userModel = _mapper.Map<UserReadDto>(userResult);
            return await Task.FromResult(Ok(userModel));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(UserCreatDto user, CancellationToken cancellationToken)
        {
            var userModel = _mapper.Map<User>(user);
            await _userRepository.AddUser(userModel, cancellationToken);
            _userRepository.Savechange();

            return await Task.FromResult(Ok(userModel));
        }
        [HttpGet("{userName}")]
        public async Task<IActionResult> GetUserByUserName(string userName, CancellationToken cancellationToken)
        {
            var result = await _userRepository.GetUserByUserName(userName, cancellationToken);
            var userModel = _mapper.Map<UserReadDto>(result);
            return await Task.FromResult(Ok(userModel));
        }
        [HttpPut("{userId}")]
        public async Task<IActionResult> UpdateUser(Guid userId, UserUpdateDto user, CancellationToken cancellationToken)
        {
            var userResult = await _userRepository.GetUserById(userId, cancellationToken);
            if (userResult == null)
            {
            }

            var userModel = _mapper.Map<User>(user);
            userModel.Id = userResult.Id;
            _userRepository.UpdateUser(userModel);
            _userRepository.Savechange();

            return await Task.FromResult(Ok(userModel));
        }

        [HttpDelete("{userId}")]
        public async Task<IActionResult> DeleteUser(Guid userId, CancellationToken cancellationToken)
        {
            var userResult = await _userRepository.GetUserById(userId, cancellationToken);
            if (userResult == null)
            {
            }

            _userRepository.DeleteUser(userResult);
            _userRepository.Savechange();

            return await Task.FromResult(Ok());
        }
    }    
}
