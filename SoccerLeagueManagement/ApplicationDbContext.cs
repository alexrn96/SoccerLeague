using Microsoft.EntityFrameworkCore;
using SoccerLeagueManagement.DBModels;

namespace SoccerLeagueManagement
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EntityTeam> Team { get; set; }
        public DbSet<EntityPlayer> Player { get; set; }
    }
}
