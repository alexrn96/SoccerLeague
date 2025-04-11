

namespace Module.SoccerLeagueManagement.Shared.DataTransferObjects;
public record PlayerTeamDto : BaseDbDto
{
    public Guid PlayerId { get; set; }
    public Guid TeamId { get; set; }
}