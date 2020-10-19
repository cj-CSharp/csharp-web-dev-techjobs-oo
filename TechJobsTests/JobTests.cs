using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.AreEqual(1, job2.Id - job1.Id);
        }

        [TestMethod]
        public void TestJobConstructionSetsAllFields ()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"),new CoreCompetency( "Persistence"));
            Assert.AreEqual("Product Tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Desert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", job1.JobType.Value);
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TestToStringBlankLineBeforeAndAfter()
        {
            Job job1 = new Job();

            Assert.AreEqual('\n', job1.ToString()[0]);
            Assert.AreEqual('\n', job1.ToString()[job1.ToString().Length-1]);
        }

        [TestMethod]
        public void TestToStringLabelAndDataForEachField()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual($"\nID: {job1.Id}\nName: Product Tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence\n", job1.ToString());
        }


        [TestMethod]
        public void TestToStringMethodForDataNotAvailable()
        {
            Job jobOnlyNameAndId = new Job();
            jobOnlyNameAndId.Name = "Product Tester";
           
            Assert.AreEqual($"\nID: {jobOnlyNameAndId.Id}\nName: Product Tester\nEmployer: Data Not Available\nLocation: Data Not Available\nPosition Type: Data Not Available\nCore Competency: Data Not Available\n", jobOnlyNameAndId.ToString());
        }

        [TestMethod]
        public void TestToStringJobWithOnlyIdField()
        {
            Job job1 = new Job();
            Assert.AreEqual("\nOOPS! This job does not seem to exist.\n", job1.ToString());
        }
    }
}
