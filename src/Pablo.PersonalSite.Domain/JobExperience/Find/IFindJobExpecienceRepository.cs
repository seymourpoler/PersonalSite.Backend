using System.Collections.Generic;

namespace Pablo.PersonalSite.Domain.JobExperience.Find
{
    public interface IFindJobExpecienceRepository
    {
        IReadOnlyList<Models.JobExperience> Find();
    }
}