

using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;

namespace Module.SoccerLeagueManagement.Shared.Interfaces;
public interface ITeamService:IGenericCrudService<EntityTeam,TeamDto>
{

}
