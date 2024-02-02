using AutoMapper;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Presentation.DTOs.User;

namespace MonitoPetsBackend.Presentation.Utilities.Profiles
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, GetUserResponseDTO>();
            CreateMap<CreateUserRequestDTO, User>();
            CreateMap<UpdateUserRequestDTO, User>();
        }
    }
}
