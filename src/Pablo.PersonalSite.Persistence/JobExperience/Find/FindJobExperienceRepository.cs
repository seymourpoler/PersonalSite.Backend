using System.Collections.Generic;
using Pablo.PersonalSite.Domain.JobExperience.Find;

namespace Pablo.PersonalSite.Persistence.JobExperience.Find
{
    public class FindJobExperienceRepository : IFindJobExpecienceRepository
    {
        public IReadOnlyList<Domain.JobExperience.Find.Models.JobExperience> Find()
        {
            throw new System.NotImplementedException();
        }
    }
}