using AutoMapper;
using Module.SoccerLeagueManagement.Infrastructure.Generics;
using Module.SoccerLeagueManagement.Shared.Interfaces;
using SoccerLeagueManagement;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;


namespace Module.SoccerLeagueManagement.Infrastructure.Services;
public class TeamService : GenericCrudService<EntityTeam, TeamDto>, ITeamService
{
    public TeamService(SoccerLeagueDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
}