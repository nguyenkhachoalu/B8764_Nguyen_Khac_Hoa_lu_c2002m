using AutoMapper;
using ExamApiAuction.Dtos.CategoryDto;
using ExamApiAuction.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamApiAuction.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryReadDto>();
            CreateMap<CategoryCreateDto, Category>();
            CreateMap<CategoryUpdateDto, Category>()
                .ForMember(otp => otp.Id, x => x.Ignore());
        }
    }
}
