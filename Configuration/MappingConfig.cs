using AutoMapper;
using TomMyLibrary.Dto;
using TomMyLibrary.Models;

namespace TomMyLibrary.Configuration;

public class MappingConfig: Profile
{
    public MappingConfig()
    {
            CreateMap<LibraryGetDto, Library>().ReverseMap();
    }
}
