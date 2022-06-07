using AutoMapper;
using ExamApiAuction.Dtos.UserDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreatDto, User>();
            CreateMap<UserUpdateDto, User>()
                .ForMember(otp => otp.Id, x => x.Ignore());
        }
    }
}
