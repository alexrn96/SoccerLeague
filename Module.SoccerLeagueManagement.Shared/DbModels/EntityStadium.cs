

using Module.SoccerLeagueManagement.Shared.Abstracts;
using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;

[Table("Stadium")]
public class EntityStadium:BaseEntity<EntityStadium>
{
    public string Name { get; set; }
    public string Capacity { get; set; }
    public string Location { get; set; }
    public ICollection<EntityPlayerStadium> PlayerStadiums { get; set; } = new List<EntityPlayerStadium>();
    public ICollection<EntityPlayer> Players { get; set; } = new List<EntityPlayer>();
}
