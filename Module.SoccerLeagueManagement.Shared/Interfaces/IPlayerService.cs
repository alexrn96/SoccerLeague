

using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;

namespace Module.SoccerLeagueManagement.Shared.Interfaces;
public interface IPlayerService:IGenericCrudService<EntityPlayer,PlayerDto>
{

}