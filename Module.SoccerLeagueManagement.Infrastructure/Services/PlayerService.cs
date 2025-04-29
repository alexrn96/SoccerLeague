using AutoMapper;
using Module.SoccerLeagueManagement.Infrastructure.Generics;
using Module.SoccerLeagueManagement.Shared.Interfaces;
using SoccerLeagueManagement;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;

namespace Module.SoccerLeagueManagement.Infrastructure.Services;
public class PlayerService : GenericCrudService<EntityPlayer, PlayerDto>, IPlayerService
{
    public PlayerService(SoccerLeagueDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
    {
    }
}