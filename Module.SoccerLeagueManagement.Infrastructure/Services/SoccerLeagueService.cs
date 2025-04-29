using AutoMapper;
using Module.SoccerLeagueManagement.Infrastructure.Generics;
using Module.SoccerLeagueManagement.Shared.DataTransferObjects;
using Module.SoccerLeagueManagement.Shared.DbModels;
using Module.SoccerLeagueManagement.Shared.Interfaces;
using SoccerLeagueManagement;


namespace Module.SoccerLeagueManagement.Infrastructure.Services;
 public class SoccerLeagueService : GenericCrudService<EntitySoccerLeague, SoccerLeagueDto>, ISoccerLeagueService
{
    public SoccerLeagueService(SoccerLeagueDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
}
