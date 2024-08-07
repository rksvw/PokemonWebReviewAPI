using AutoMapper;
using GameStore.Dto;
using GameStore.Models;
namespace GameStore.AutoMapper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDto>();
        }
    }
}
