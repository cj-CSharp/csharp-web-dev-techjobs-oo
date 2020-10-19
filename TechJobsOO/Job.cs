using System;
using System.Text;

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
        public Job ()
        {
            Id = nextId;
            nextId++;
        }
        public Job (string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
        }

        public override bool Equals(object obj)
        {
            if(obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Job j = obj as Job;
            return j.Id == Id;    
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            int nullCounter = 0;

            string jobName;
            string jobEmployerName;
            string jobEmployerLocation;
            string jobJobType;
            string jobJobCoreComp;

            if(Name == null || Name == "")
            {
                jobName = "Data Not Available";
                nullCounter++;
            } else
            {
                jobName = Name;
            }

            if(EmployerName == null || EmployerName.Value == "")
            {
                jobEmployerName = "Data Not Available";
                nullCounter++;
            } else
            {
                jobEmployerName = EmployerName.Value;
            }

            if(EmployerLocation == null || EmployerLocation.Value == "")
            {
                jobEmployerLocation = "Data Not Available";
                nullCounter++;
            } else
            {
                jobEmployerLocation = EmployerLocation.Value;
            }

            if(JobType == null || JobType.Value == "")
            {
                jobJobType = "Data Not Available";
                nullCounter++;
            } else
            {
                jobJobType = JobType.Value;
            }

            if(JobCoreCompetency == null || JobCoreCompetency.Value == "")
            {
                jobJobCoreComp = "Data Not Available";
                nullCounter++;
            } else
            {
                jobJobCoreComp = JobCoreCompetency.Value;
            }
              
            if(nullCounter == 5)
            {
                return "\nOOPS! This job does not seem to exist.\n";
            }

            result.Append($"ID: {Id}\n");
            result.Append($"Name: {jobName}\n");
            result.Append($"Employer: {jobEmployerName}\n");
            result.Append($"Location: {jobEmployerLocation}\n");
            result.Append($"Position Type: {jobJobType}\n");
            result.Append($"Core Competency: {jobJobCoreComp}");

            return "\n" + result.ToString() + "\n";
        }
    }
}
