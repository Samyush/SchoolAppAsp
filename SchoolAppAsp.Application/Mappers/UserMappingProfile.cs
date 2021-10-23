using AutoMapper;
using SchoolAppASP.Application.Commands;

public class UserMappingProfile : Profile
{
    public UserMappingProfile()
    {
        CreateMap<SchoolAppASP.Core.Entities.UsersDB, UserResponse>().ReverseMap();
        CreateMap<SchoolAppASP.Core.Entities.UsersDB, CreateUsersCommand>().ReverseMap();
    }
}