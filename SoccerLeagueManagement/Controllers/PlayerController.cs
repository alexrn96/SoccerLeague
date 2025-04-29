using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module.SoccerLeagueManagement.Server.Generics;
using Module.SoccerLeagueManagement.Shared.Interfaces;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;

namespace Module.SoccerLeagueManagement.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : GenericCrudController<EntityPlayer, PlayerDto>
    {
        public PlayerController(IGenericCrudService<EntityPlayer, PlayerDto> genericCrudService) : base(genericCrudService)
        {
        }
    }
}
