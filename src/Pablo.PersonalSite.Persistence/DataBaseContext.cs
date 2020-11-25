using Microsoft.EntityFrameworkCore;

namespace Pablo.PersonalSite.Persistence
{
    public class DataBaseContext : DbContext
    {
        private readonly string connectionString;

        public DataBaseContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(connectionString);
        }
    }
}