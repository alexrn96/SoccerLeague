

using Module.SoccerLeagueManagement.Shared.Abstracts;
using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;
[Table("SoccerLeague")]
public class EntitySoccerLeague:BaseEntity<EntitySoccerLeague>
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Location { get; set; }
    public ICollection<EntityPlayerSoccerLeague> PlayerSoccerLeagues { get; set; } = new List<EntityPlayerSoccerLeague>();
    public ICollection<EntityPlayer> Players { get; set; } = new List<EntityPlayer>();
}
