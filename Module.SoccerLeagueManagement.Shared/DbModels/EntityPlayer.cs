using Module.SoccerLeagueManagement.Shared.Abstracts;
using Module.SoccerLeagueManagement.Shared.DbModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerLeagueManagement.DBModels;

[Table("Player")]
public class EntityPlayer:BaseEntity<EntityPlayer>
{
    public string Name { get; set; }
    public string Number { get; set; }
    public string PlayingPosition { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public string Telephone { get; set; }
    public ICollection<EntityTeam> Teams { get; set; } = new List<EntityTeam>();
    public ICollection<EntityStadium> Stadiums { get; set; } = new List<EntityStadium>();
    public ICollection<EntitySoccerLeague> SoccerLeagues { get; set; } = new List<EntitySoccerLeague>();
    public ICollection<EntitySoccerGame> SoccerGames { get; set; } = new List<EntitySoccerGame>();

    public ICollection<EntityPlayerTeam> PlayerTeams { get; set; } = new List<EntityPlayerTeam>();
    public ICollection<EntityPlayerStadium> PlayerStadiums { get; set; } = new List<EntityPlayerStadium>();
    public ICollection<EntityPlayerSoccerLeague> PlayerSoccerLeagues { get; set; } = new List<EntityPlayerSoccerLeague>();
    public ICollection<EntityPlayerSoccerGame> PlayerSoccerGames { get; set; } = new List<EntityPlayerSoccerGame>();

}
