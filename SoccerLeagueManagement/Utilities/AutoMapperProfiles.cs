using AutoMapper;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;
namespace SoccerLeagueManagement.Utilities;
public class AutoMapperProfiles : Profile
{
   public AutoMapperProfiles()
   {
        CreateMap<EntityTeam, TeamDto>().ReverseMap();
        CreateMap<EntityPlayer, PlayerDto>().ReverseMap();
   }
}
