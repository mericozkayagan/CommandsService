using AutoMapper;
using CommandsService.Dtos;
using CommandsService.Models;

namespace CommandsService.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CommandCreateDto, Command>();
            CreateMap<Command, CommandReadDto>();
            CreateMap<Platform, PlatformReadDto>();
        }
    }
}