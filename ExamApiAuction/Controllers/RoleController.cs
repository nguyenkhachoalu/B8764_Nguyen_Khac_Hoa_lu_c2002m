using AutoMapper;
using ExamApiAuction.Dtos;
using ExamApiAuction.Dtos.RolesDto;
using ExamApiAuction.Model;
using ExamApiAuction.Repositores.IRepositores;
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
    public class RoleController : ControllerBase
    {
        private readonly IRolesRepository _rolesRepository;
        private IMapper _mapper;

        public RoleController(IRolesRepository rolesRepository, IMapper mapper)
        {
            _rolesRepository = rolesRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetRolesAsync(CancellationToken cancellationToken)
         {
            var result = await _rolesRepository.GetRolesAsync(cancellationToken);
            return await Task.FromResult(Ok(result));
        }

        //[HttpGet("{roleId}", Name = "GetRoleById")]
        //public async ActionResult<Task<RolesReadDto>> GetRoleById(int roleId, CancellationToken cancellationToken)
        //{
        //    var findId = await _rolesRepository.GetRoleById(roleId, cancellationToken);
        //    return Ok(_mapper.Map<RolesReadDto>(findId));
        //}
        [HttpPost]
        public async Task<IActionResult> CreateRole(RoleCreateDto role, CancellationToken cancellationToken)
        {
            var roleModel = _mapper.Map<Roles>(role);
            await _rolesRepository.AddRole(roleModel, cancellationToken);
            _rolesRepository.Savechange();

            return await Task.FromResult(Ok(roleModel));
        }
        [HttpPut("{roleId}")]
        public async Task<IActionResult> UpdateRole(int roleId,RoleUpdateDto role, CancellationToken cancellationToken)
        {
            var roleResult = await _rolesRepository.GetRoleById(roleId, cancellationToken);
            if(roleResult == null)
            {
            }

            var roleModel = _mapper.Map<Roles>(role);
            roleModel.Id = roleResult.Id;
            _rolesRepository.UpdateRole(roleModel);
            _rolesRepository.Savechange();

            return await Task.FromResult(Ok(roleModel));
        }
        [HttpDelete("{roleId}")]
        public async Task<IActionResult> DeleteRole(int roleId, CancellationToken cancellationToken)
        {
            var roleResult = await _rolesRepository.GetRoleById(roleId, cancellationToken);
            if (roleResult == null)
            {
            }

            _rolesRepository.DeleteRole(roleResult);
            _rolesRepository.Savechange();

            return await Task.FromResult(Ok());
        }
    }
}
