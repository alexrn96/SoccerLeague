using Module.SoccerLeagueManagement.Shared.Interfaces;

namespace Module.SoccerLeagueManagement.Shared.DataTransferObjects;
public abstract record BaseDbDto : IBaseDbDto
{
    public Guid Id { get; set; }

    private DateTime _modifiedAt = DateTime.UtcNow;
    public DateTime ModifiedAt
    {
        get => _modifiedAt;
        set => _modifiedAt = DateTime.UtcNow;
    }
}
