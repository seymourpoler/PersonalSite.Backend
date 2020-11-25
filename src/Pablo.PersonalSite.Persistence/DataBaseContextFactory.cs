namespace Pablo.PersonalSite.Persistence
{
    public class DataBaseContextFactory
    {
        private readonly Configuration configuration;

        public DataBaseContextFactory(Configuration configuration)
        {
            this.configuration = configuration;
        }
    }
}