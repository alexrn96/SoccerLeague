using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module.SoccerLeagueManagement.Server.Generics;
using Module.SoccerLeagueManagement.Shared.DataTransferObjects;
using Module.SoccerLeagueManagement.Shared.DbModels;
using Module.SoccerLeagueManagement.Shared.Interfaces;

namespace Module.SoccerLeagueManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SoccerLeagueController : GenericCrudController<EntitySoccerLeague, SoccerLeagueDto>
    {
        public SoccerLeagueController(IGenericCrudService<EntitySoccerLeague, SoccerLeagueDto> genericCrudService) : base(genericCrudService)
        {
        }
    }
}
