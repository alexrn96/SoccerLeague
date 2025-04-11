
using Microsoft.EntityFrameworkCore;
using Module.SoccerLeagueManagement.Shared.DbModels;
using SoccerLeagueManagement.DBModels;

namespace SoccerLeagueManagement
{
    public class SoccerLeagueDbContext : DbContext
    {
        public SoccerLeagueDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<EntityTeam> Team { get; set; }
        public DbSet<EntityPlayer> Player { get; set; }
        public DbSet<EntityStadium> Stadium { get; set; }
        public DbSet<EntitySoccerLeague> SoccerLeague { get; set; }
        public DbSet<EntitySoccerGame> SoccerGame { get; set; }
        public DbSet<EntityPlayerTeam> PlayerTeam { get; set; }
        public DbSet<EntityPlayerSoccerGame> PlayerSoccerGame { get; set; }
        public DbSet<EntityPlayerStadium> PlayerStadium { get; set; }
        public DbSet<EntityPlayerSoccerLeague> PlayerSoccerLeague { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EntityPlayer>()
             .HasMany(e => e.Teams)
             .WithMany(e => e.Players)
             .UsingEntity<EntityPlayerTeam>();

            modelBuilder.Entity<EntityPlayer>()
            .HasMany(e => e.Stadiums)
            .WithMany(e => e.Players)
            .UsingEntity<EntityPlayerStadium>();

            modelBuilder.Entity<EntityPlayer>()
            .HasMany(e => e.SoccerLeagues)
            .WithMany(e => e.Players)
            .UsingEntity<EntityPlayerSoccerLeague>();

            modelBuilder.Entity<EntityPlayer>()
            .HasMany(e => e.SoccerGames)
            .WithMany(e => e.Players)
            .UsingEntity<EntityPlayerSoccerGame>();
        }
    }
}
