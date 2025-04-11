

using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;

[Table("PlayerStadium")]
public class EntityPlayerStadium
{
    public Guid PlayerId { get; set; }
    public Guid StadiumId { get; set; }


    [ForeignKey(nameof(PlayerId))]
    public EntityPlayer EntityPlayer { get; set; } = null!;

    [ForeignKey(nameof(StadiumId))]
    public EntityStadium EntityStadium { get; set; } = null!;
}