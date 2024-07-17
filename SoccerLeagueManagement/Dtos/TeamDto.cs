
namespace SoccerLeagueManagement.Dtos;
public class TeamDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<PlayerDto> Players = new List<PlayerDto>();
}
