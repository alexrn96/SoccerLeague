
using Module.SoccerLeagueManagement.Shared.DataTransferObjects;

namespace SoccerLeagueManagement.Dtos;
public record TeamDto:BaseDbDto
{
    public string Name { get; set; }
    public IEnumerable<PlayerDto> Players = new List<PlayerDto>();
}
