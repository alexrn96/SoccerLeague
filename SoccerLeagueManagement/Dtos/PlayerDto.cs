
namespace SoccerLeagueManagement.Dtos;
public class PlayerDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string IDNumber { get; set; }
    public string playingPosition { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string TelePhone { get; set; }
    public int TeamId { get; set; }
    public TeamDto Team { get; set; }
}
