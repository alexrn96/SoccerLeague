
using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;

[Table("PlayerSoccerLeague")]
public class EntityPlayerSoccerLeague
{
    public Guid PlayerId { get; set; }
    public Guid SoccerLeagueId { get; set; }

    [ForeignKey(nameof(PlayerId))]
    public EntityPlayer EntityPlayer { get; set; } = null!;

    [ForeignKey(nameof(SoccerLeagueId))]
    public EntitySoccerLeague EntitySoccerLeague { get; set; } = null!;
}
