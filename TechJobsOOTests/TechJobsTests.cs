using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TechJobsOO;

namespace TechJobsOOTests
{
    [TestClass]
    public class TechJobsTests
    {
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
            Assert.AreEqual("Product tester", test_job2.Name.ToString());
            Assert.AreEqual("Desert", test_job2.EmployerLocation.ToString());
            Assert.AreEqual("ACME", test_job2.EmployerName.ToString());
            Assert.AreEqual("Quality control", test_job2.JobType.ToString());
            Assert.AreEqual("Persistence", test_job2.JobCoreCompetency.ToString());
        }


         [TestMethod]
        public void TestToStringIfEmpty()
        {
            Assert.AreEqual("Data not available", test_job4.EmployerLocation.ToString());
            Assert.AreEqual("Data not available", test_job4.EmployerName.ToString());
            Assert.AreEqual("Data not available", test_job4.JobType.ToString());
            Assert.AreEqual("Data not available", test_job4.JobCoreCompetency.ToString());
        }
    }
}
