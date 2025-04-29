
namespace Module.SoccerLeagueManagement.Shared.DataTransferObjects;
public record SoccerLeagueDto:BaseDbDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Location { get; set; }
}
