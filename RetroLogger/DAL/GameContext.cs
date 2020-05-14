using RetroLogger.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RetroLogger.DAL
{
    public class GameContext : DbContext
    {

        public GameContext() : base("GameContext")
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Console> Consoles { get; set; }
        public DbSet<Controller> Controllers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}