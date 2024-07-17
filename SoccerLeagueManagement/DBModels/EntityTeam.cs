namespace SoccerLeagueManagement.DBModels;
public class EntityTeam
{
    public int Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<EntityPlayer> Players =new List<EntityPlayer>();
}
