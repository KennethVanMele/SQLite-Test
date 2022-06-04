using Microsoft.EntityFrameworkCore;

namespace SQLite_EF
{
    public class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Platform> Platforms { get; set; }

        public string DbPath { get; }

        public GameContext()
        {
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "repos\\SQLite Test\\test_EF.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");
    }
}