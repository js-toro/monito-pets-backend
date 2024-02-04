using AutoMapper;
using MonitoPetsBackend.Domain.Entities;
using MonitoPetsBackend.Presentation.DTOs.Color;

namespace MonitoPetsBackend.Presentation.Utilities.AutoMapperProfiles
{
    public class ColorMapperProfile : Profile
    {
        public ColorMapperProfile()
        {
            CreateMap<Color, GetColorResponseDTO>();
            CreateMap<CreateColorRequestDTO, Color>();
            CreateMap<UpdateColorRequestDTO, Color>();
        }
    }
}
