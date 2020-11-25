namespace Pablo.PersonalSite.Domain.JobExperience.Find.Models
{
    public class JobExperience
    {
        public string Company { get; }
        public string Description { get; }
        
        public JobExperience(string company, string description)
        {
            Company = company;
            Description = description;
        }
    }
}