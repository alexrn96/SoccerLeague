

using Module.SoccerLeagueManagement.Shared.Abstracts;
using SoccerLeagueManagement.DBModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Module.SoccerLeagueManagement.Shared.DbModels;
[Table("SoccerGame")]
public class EntitySoccerGame:BaseEntity<EntitySoccerGame>
{
    public string LocalTeam {  get; set; }
    public string VisitingTeam { get; set; }
    public DateOnly Date {  get; set; } 
    public TimeOnly Time { get; set; }
    public int LocalTeamGoals { get; set; }
    public int VisitingTeamGoals { get; set; }
    public string Marker { get; set; }
    public ICollection<EntityPlayerSoccerGame> PlayerSoccerGames { get; set; } = new List<EntityPlayerSoccerGame>();
    public ICollection<EntityPlayer> Players { get; set; } = new List<EntityPlayer>();

}
