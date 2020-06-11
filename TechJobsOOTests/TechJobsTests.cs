using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TechJobsOO;

namespace TechJobsOOTests
{
    [TestClass]
    public class TechJobsTests
    {

        [TestMethod]
        public void TestMethod1()
        {
        }

        Job test_job = new Job();
        Job test_job1 = new Job();
        Job test_job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        Job test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));






        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.IsTrue(test_job1.Id == test_job.Id + 1);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(test_job1.Id + 1 == test_job2.Id);
            Assert.IsTrue("Product tester" == test_job2.Name);
            Assert.IsTrue("ACME" == test_job2.EmployerName.Value);
            Assert.IsTrue("Desert" == test_job2.EmployerLocation.Value);
            Assert.IsTrue("Quality control" == test_job2.JobType.Value);
            Assert.IsTrue("Persistence" == test_job2.JobCoreCompetency.ToString());
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(test_job2.Equals(test_job3));
        }
        [TestMethod]
        public void TestToStringNewLines()
        {
            string jobString = test_job.ToString();

            string[] arrJobString = jobString.Split("\n");

            Assert.IsTrue(arrJobString.Length >= 2 && arrJobString[0] == string.Empty && arrJobString[arrJobString.Length - 1] == string.Empty);
        }
        [TestMethod]
        public void TestToStringData()
        {
            string jobString = test_job2.ToString();

            string[] arrJobString = jobString.Split("\n");

            Assert.IsTrue(arrJobString.Contains($"ID: {test_job2.Id}"));
            Assert.IsTrue(arrJobString.Contains($"Name: {test_job2.Name}"));
            Assert.IsTrue(arrJobString.Contains($"Employer: {test_job2.EmployerName}"));
            Assert.IsTrue(arrJobString.Contains($"Location: {test_job2.EmployerLocation}"));
            Assert.IsTrue(arrJobString.Contains($"Position Type: {test_job2.JobType}"));
            Assert.IsTrue(arrJobString.Contains($"Core Competency: {test_job2.JobCoreCompetency}"));
        }


         [TestMethod]
        public void TestToStringIfEmpty()
        {
            Job test_job = new Job();
            string jobString = test_job.ToString();

            string[] arrJobString = jobString.Split("\n");

            Assert.IsTrue(arrJobString.Contains($"ID: {test_job.Id}"));
            Assert.IsTrue(arrJobString.Contains($"Name: Data not available"));
            Assert.IsTrue(arrJobString.Contains($"Employer: Data not available"));
            Assert.IsTrue(arrJobString.Contains($"Location: Data not available"));
            Assert.IsTrue(arrJobString.Contains($"Position Type: Data not available"));
            Assert.IsTrue(arrJobString.Contains($"Core Competency: Data not available"));

            //$"Name: {job.Name ?? "Data not available"}"
        }
       
        //Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    }
}

/*

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {
        public const string PRODUCT_TEST = "Product test";
        public const string EMPLOYER = "ACME";
        public const string LOCATION = "Desert";
        public const string POSITION = "Quality control";
        public const string CORE = "Persistence";

        public Job GetJob()
        {
            return new Job(PRODUCT_TEST,
                            new Employer(EMPLOYER),
                            new Location(LOCATION),
                            new PositionType(POSITION),
                            new CoreCompetency(CORE));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job = GetJob();

            Job job2 = GetJob();

            Assert.IsTrue(job2.Id != job.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job = GetJob();

            Assert.IsTrue(job.Name == PRODUCT_TEST &&
                          job.Employer?.Value == EMPLOYER &&
                          job.Location?.Value == LOCATION &&
                          job.PositionType?.Value == POSITION &&
                          job.CoreCompetency?.Value == CORE);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job = GetJob();

            Job job2 = GetJob();

            Assert.IsFalse(job.Equals(job2));
        }

        [TestMethod]
        public void JobToStringHasDelimiters()
        {
            Job job = GetJob();

            string s = job.ToString();

            string[] arr = s.Split("\n");

            Assert.IsTrue(arr.Count() >= 2 && arr.First() == string.Empty && arr.Last() == string.Empty);
        }

        [TestMethod]
        public void JobToStringPrintsArgsOnNewLines()
        {
            Job job = GetJob();

            string s = job.ToString();

            string[] arr = s.Split("\n");

            Assert.IsTrue(arr.Any(s => s == $"ID: {job.Id}"));
            Assert.IsTrue(arr.Any(s => s == $"Name: {job.Name}"));
            Assert.IsTrue(arr.Any(s => s == $"Employer: {job.Employer}"));
            Assert.IsTrue(arr.Any(s => s == $"Location: {job.Location}"));
            Assert.IsTrue(arr.Any(s => s == $"Position Type: {job.PositionType}"));
            Assert.IsTrue(arr.Any(s => s == $"Core Competency: {job.CoreCompetency}"));
        }

        [TestMethod]
        public void JobToStringPrintsNullArgsCoallesceOnPrint()
        {
            Job job = new Job();

            string s = job.ToString();

            string[] arr = s.Split("\n");

            Assert.IsTrue(arr.Any(s => s == $"ID: {job.Id}"));
            Assert.IsTrue(arr.Any(s => s == $"Name: {job.Name ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Employer: {job.Employer?.ToString() ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Location: {job.Location?.ToString() ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Position Type: {job.PositionType?.ToString() ?? "Data not available"}"));
            Assert.IsTrue(arr.Any(s => s == $"Core Competency: {job.CoreCompetency?.ToString() ?? "Data not available"}"));
        }
    }
}


*/