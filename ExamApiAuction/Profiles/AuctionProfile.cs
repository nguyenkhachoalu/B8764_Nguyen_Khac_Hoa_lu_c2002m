using AutoMapper;
using ExamApiAuction.Dtos.AuctionDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Profiles
{
    public class AuctionProfile : Profile
    {
        public AuctionProfile()
        {
            CreateMap<Auction, AuctionReadDto>();
            CreateMap<AuctionCreateDto, Auction>();
            CreateMap<AuctionUpdateDto, Auction>()
                .ForMember(otp => otp.Id, x => x.Ignore());
        }
    }
}
