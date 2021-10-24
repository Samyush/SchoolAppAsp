using AutoMapper;
using SchoolAppASP.Application.Commands;

namespace SchoolAppASP.Application.Mappers
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<Core.Entities.UsersDB, UserResponse>().ReverseMap();
            CreateMap<Core.Entities.UsersDB, CreateUsersCommand>().ReverseMap();
        }
    }
}