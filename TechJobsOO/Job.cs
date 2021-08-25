using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
        public Job(string name, Employer employer, Location location, PositionType positionType, CoreCompetency coreCompetency) : this()
        {
            Name = name ?? "Data Not Available";
            EmployerName = employer ?? new Employer("Data Not Available");
            EmployerLocation = location ?? new Location("Data Not Available");
            JobType = positionType ?? new PositionType("Data Not Available");
            JobCoreCompetency = coreCompetency ?? new CoreCompetency("Data Not Available");
        }

        public Job(string name, string employerName, string employerLocation, string jobType, string jobCoreCompetency)
        {
            Name = name ?? "Data Not Available";
            EmployerName = new Employer(employerName ?? "Data Not Available");
            EmployerLocation = new Location(employerLocation ?? "Data Not Available");
            JobType = new PositionType(jobType ?? "Data Not Available");
            JobCoreCompetency = new CoreCompetency (jobCoreCompetency ?? "Data Not Available");
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override string ToString()
        {
            string employmentString = @"
            ID: {0}
            Name: {1}
            Employer: {2}
            Location: {3}
            Position Type: {4}
            Core Competency: {5}
            ";
            return string.Format(employmentString, this.Id, this.Name, this.EmployerName.Value, this.EmployerLocation.Value, this.JobType.Value, this.JobCoreCompetency.Value);

            
        }

    }
}
