using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoccerLeagueManagement.DBModels;
using SoccerLeagueManagement.Dtos;
using System.Runtime;

namespace SoccerLeagueManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public TeamController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<TeamDto>>> GetTeams()
        {
            List<EntityTeam> entityTeams = await context.Team.ToListAsync();

            List<TeamDto> teams = mapper.Map<List<TeamDto>>(entityTeams);
            return teams;
        }
        [HttpGet("{id:int}", Name ="GetCurrentTeam")]
        public async Task<ActionResult<TeamDto>> GetTeam(int id)
        {
            EntityTeam team = await context.Team.FirstOrDefaultAsync(x => x.Id == id);
            if(team is null)
            {
                return NotFound();
            }
            return mapper.Map<TeamDto>(team);
        }
        [HttpPost]
        public async Task<ActionResult> SaveTeam(TeamDto team)
        {
            EntityTeam entityTeam = mapper.Map<EntityTeam>(team);
            context.Add(entityTeam);
            await context.SaveChangesAsync();

            TeamDto teamdto = mapper.Map<TeamDto>(entityTeam);
            return Ok(teamdto.Id);
        }
        [HttpPut ("{id}")]
        public async Task<ActionResult> UpdateTeam(int id,[FromBody] TeamDto team)
        {
            EntityTeam entityTeam = mapper.Map<EntityTeam>(team);
            entityTeam.Id = id;
            context.Entry(entityTeam).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete ("{id:int}")]
        public async Task<ActionResult<int>> DeleteTeam(int id)
        {
            bool existTeam = await context.Team.AnyAsync(x => x.Id == id);
            if (!existTeam)
            {
                return NotFound();
            }
            context.Remove(new EntityTeam() { Id = id });
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}
