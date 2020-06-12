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
        Job test_job4 = new Job("", new Employer(""), new Location(""), new PositionType(""), new CoreCompetency(""));






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
            Assert.AreEqual("Data not available", test_job4.EmployerLocation.ToString());
            Assert.AreEqual("Data not available", test_job4.EmployerName.ToString());
            Assert.AreEqual("Data not available", test_job4.JobType.ToString());
            Assert.AreEqual("Data not available", test_job4.JobCoreCompetency.ToString());
        }
       
        //Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
    }
}
