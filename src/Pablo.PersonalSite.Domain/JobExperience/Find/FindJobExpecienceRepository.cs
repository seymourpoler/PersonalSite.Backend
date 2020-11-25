using System.Collections.Generic;

namespace Pablo.PersonalSite.Domain.JobExperience.Find
{
    public interface IFindJobExpecienceRepository
    {
        IReadOnlyList<Models.JobExperience> Find();
    }

    public class FindJobExpecienceRepository : IFindJobExpecienceRepository
    {
        public IReadOnlyList<Models.JobExperience> Find()
        {
            throw new System.NotImplementedException();
        }
    }
}