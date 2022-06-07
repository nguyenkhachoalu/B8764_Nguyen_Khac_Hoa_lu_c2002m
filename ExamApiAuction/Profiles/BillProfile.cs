using AutoMapper;
using ExamApiAuction.Dtos.BillDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Profiles
{
    public class BillProfile : Profile
    {
        public BillProfile()
        {
            CreateMap<Bill, BillReadDto>();
            CreateMap<BillCreateDto, Bill>();
            CreateMap<BillUpdateDto, Bill>()
                .ForMember(otp => otp.Id, x => x.Ignore());
        }
    }
}
