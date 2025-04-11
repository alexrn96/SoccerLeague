using AutoMapper;
using Module.SoccerLeagueManagement.Shared.DataTransferObjects;
using Module.SoccerLeagueManagement.Shared.DbModels;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;
namespace SoccerLeagueManagement.Utilities;
public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<EntityTeam, TeamDto>().ReverseMap();
        CreateMap<EntityPlayer, PlayerDto>().ReverseMap();
        CreateMap<EntityPlayerTeam, PlayerTeamDto>().ReverseMap();
    }
}
