

using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;

[Table("PlayerTeam")]

public class EntityPlayerTeam
{
    public Guid PlayerId { get; set; }
    public Guid TeamId { get; set; }
    

    [ForeignKey(nameof(PlayerId))]
    public EntityPlayer EntityPlayer { get; set; } = null!;

    [ForeignKey(nameof(TeamId))]
    public EntityTeam EntityTeam { get; set; } = null!;
}
