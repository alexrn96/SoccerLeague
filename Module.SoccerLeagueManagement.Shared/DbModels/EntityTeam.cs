using Module.SoccerLeagueManagement.Shared.Abstracts;
using Module.SoccerLeagueManagement.Shared.DbModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerLeagueManagement.DBModels;
[Table("Team")]
public class EntityTeam: BaseEntity<EntityTeam>
{
    public string Name { get; set; }
    public ICollection<EntityPlayerTeam> PlayerTeams { get; set; } = new List<EntityPlayerTeam>();
    public ICollection<EntityPlayer> Players { get; set; } = new List<EntityPlayer>();
}
