using BargainMagic.DataAccess.Abstractions.Entities;

using Microsoft.EntityFrameworkCore;

namespace BargainMagic.DataAccess.EntityFramework
{
    public class BargainMagicContext : DbContext
    {
        public string DatabasePath { get; set; }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<SeasonCardCost> SeasonCardCosts { get; set; }

        public BargainMagicContext()
        {
            var applicationDirectory = Directory.GetCurrentDirectory();
            this.DatabasePath = Path.Join(applicationDirectory, "bargainmagic.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DatabasePath}");
        }
    }
}
