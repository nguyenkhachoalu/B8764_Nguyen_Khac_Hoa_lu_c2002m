using AutoMapper;
using ExamApiAuction.Dtos;
using ExamApiAuction.Dtos.RolesDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Profiles
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            //source -> target
            CreateMap<Roles, RolesReadDto>();
            CreateMap<RoleCreateDto, Roles>();
            CreateMap<RoleUpdateDto,Roles>()
                .ForMember(otp => otp.Id, x => x.Ignore());
        }
    }
}
