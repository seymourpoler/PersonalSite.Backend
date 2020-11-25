using Microsoft.EntityFrameworkCore;

namespace Pablo.PersonalSite.Persistence
{
    public class DataBaseContext : DbContext
    {
        private readonly Configuration configuration;

        public DataBaseContext(Configuration configuration)
        {
            this.configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(configuration.ConnectionString);
        }
    }
}