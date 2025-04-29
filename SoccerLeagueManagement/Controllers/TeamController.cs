using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Module.SoccerLeagueManagement.Server.Generics;
using Module.SoccerLeagueManagement.Shared.Interfaces;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;

namespace SoccerLeagueManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : GenericCrudController<EntityTeam,TeamDto>
    {
        
        public TeamController(IGenericCrudService<EntityTeam, TeamDto> genericCrudService) : base(genericCrudService)
        {
        }

        //public TeamController(SoccerLeagueDbContext context, IMapper mapper)
        //{
        //    this.context = context;
        //    this.mapper = mapper;
        //}
        //[HttpGet]
        //public async Task<ActionResult<List<TeamDto>>> GetTeams()
        //{
        //    List<EntityTeam> entityTeams = await context.Team.ToListAsync();

        //    List<TeamDto> teams = mapper.Map<List<TeamDto>>(entityTeams);
        //    return teams;
        //}
        //[HttpGet("{id:guid}", Name ="GetCurrentTeam")]
        //public async Task<ActionResult<TeamDto>> GetTeam(Guid id)
        //{
        //    EntityTeam team = await context.Team.FirstOrDefaultAsync(x => x.Id == id);
        //    if(team is null)
        //    {
        //        return NotFound();
        //    }
        //    return mapper.Map<TeamDto>(team);
        //}
        //[HttpPost]
        //public async Task<ActionResult> SaveTeam(TeamDto team)
        //{
        //    EntityTeam entityTeam = mapper.Map<EntityTeam>(team);
        //    context.Add(entityTeam);
        //    await context.SaveChangesAsync();

        //    TeamDto teamdto = mapper.Map<TeamDto>(entityTeam);
        //    return Ok(teamdto.Id);
        //}
        //[HttpPut ("{id}")]
        //public async Task<ActionResult> UpdateTeam(Guid id,[FromBody] TeamDto team)
        //{
        //    EntityTeam entityTeam = mapper.Map<EntityTeam>(team);
        //    entityTeam.Id = id;
        //    context.Entry(entityTeam).State = EntityState.Modified;
        //    await context.SaveChangesAsync();
        //    return NoContent();
        //}
        //[HttpDelete ("{id:guid}")]
        //public async Task<ActionResult<int>> DeleteTeam(Guid id)
        //{
        //    bool existTeam = await context.Team.AnyAsync(x => x.Id == id);
        //    if (!existTeam)
        //    {
        //        return NotFound();
        //    }
        //    context.Remove(new EntityTeam() { Id = id });
        //    await context.SaveChangesAsync();
        //    return NoContent();
        //}
    }
}
