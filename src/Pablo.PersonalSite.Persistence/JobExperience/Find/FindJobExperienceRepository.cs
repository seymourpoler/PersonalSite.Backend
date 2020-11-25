using System.Collections.Generic;
using System.Linq;
using Pablo.PersonalSite.Domain.JobExperience.Find;

namespace Pablo.PersonalSite.Persistence.JobExperience.Find
{
    public class FindJobExperienceRepository : IFindJobExpecienceRepository
    {
        private readonly DataBaseContextFactory dataBaseContextFactory;

        public FindJobExperienceRepository(DataBaseContextFactory dataBaseContextFactory)
        {
            this.dataBaseContextFactory = dataBaseContextFactory;
        }

        public IReadOnlyList<Domain.JobExperience.Find.Models.JobExperience> Find()
        {
            using var dbContext = dataBaseContextFactory.Create();
            return dbContext.JobExperiences
                .Select(Build)
                .ToList()
                .AsReadOnly();
        }

        private Domain.JobExperience.Find.Models.JobExperience Build(
            JobExperience.Models.JobExperience jobExperience)
        {
            return new Domain.JobExperience.Find.Models.JobExperience(
                jobExperience.Company, jobExperience.Description);
        }
    }
}