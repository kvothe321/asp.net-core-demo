using asp.net_core_demo.Dto;
using asp.net_core_demo.Entities;
using AutoMapper;

namespace asp.net_core_demo.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserBasicDTO>();

            CreateMap<UserRegisterDTO, User>();
        }
    }
}
