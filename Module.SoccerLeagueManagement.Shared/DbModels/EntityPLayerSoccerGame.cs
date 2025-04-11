

using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;
[Table("PlayerSoccerGame")]
public class EntityPlayerSoccerGame
{
    public Guid PlayerId { get; set; }
    public Guid SoccerGameId { get; set; }

    [ForeignKey(nameof(PlayerId))]
    public EntityPlayer EntityPlayer { get; set; } = null!;

    [ForeignKey(nameof(SoccerGameId))]
    public EntitySoccerGame EntitySoccerGame { get; set; } = null!;
}