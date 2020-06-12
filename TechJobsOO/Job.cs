using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }

        private const string V = "Data not available";
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors. Done
        public Job()
        {
            Id = nextId;
            nextId++;

        }
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobcoreCompetency) : this()
        {

            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobcoreCompetency;
        }


        // TODO: Generate Equals() and GetHashCode() methods. Done
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string stringPrinted = $"\nID: {Id}\nName: {Name}\nEmployer: {EmployerName}\nLocation: {EmployerLocation}\nPosition Type: {JobType}\nCore Competency: {JobCoreCompetency}\n";
            return stringPrinted;
        }
    }
}

