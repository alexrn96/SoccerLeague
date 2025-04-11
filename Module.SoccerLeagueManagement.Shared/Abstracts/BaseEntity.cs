
using System.ComponentModel.DataAnnotations;

namespace Module.SoccerLeagueManagement.Shared.Abstracts;
public abstract class BaseEntity<TEntity> where TEntity : BaseEntity<TEntity>
{
    [Key]
    public Guid Id { get; set; }    = Guid.NewGuid();
    private DateTime _modifiedAt = DateTime.UtcNow;
    public DateTime ModifiedAt
    {
        get => _modifiedAt;
        set => _modifiedAt = DateTime.UtcNow;
    }
}
