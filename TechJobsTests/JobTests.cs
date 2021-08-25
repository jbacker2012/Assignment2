using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;

namespace TechJobsTests
{
    [TestClass]
    public class TechJobsTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual(0, test_job.Id, 1);
        }

        Job test_job;

        [TestInitialize]
        public void CreateJobObject()
        {
            test_job = new Job("Engineer", "Launch Code", "Saint Louis", "Programmer", "Programming");
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            var testJob1 = new Job("Product tester", "ACME", "Desert", "Quality control", "Persistence");
            Assert.AreEqual("Product tester", testJob1.Name);
            Assert.AreEqual("ACME", testJob1.EmployerName.Value);
            Assert.AreEqual("Desert", testJob1.EmployerLocation.Value);
            Assert.AreEqual("Quality control", testJob1.JobType.Value);
            Assert.AreEqual("Persistence", testJob1.JobCoreCompetency.Value);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            var testJob1 = new Job("Groomer", "Doggie Love", "Mars", "Dog Groomer", "Grooming");
            var testJob2 = new Job("Groomer", "Doggie Love", "Mars", "Dog Groomer", "Grooming");
            Assert.IsFalse(testJob1.Equals(testJob2));
           
        }

        [TestMethod]
        public void TestJobToStringWithValidData()
        {
            string testString = @"
            ID: {0}
            Name: {1}
            Employer: {2}
            Location: {3}
            Position Type: {4}
            Core Competency: {5}
            ";
            Assert.AreEqual(string.Format(testString, test_job.Id, test_job.Name, test_job.EmployerName.Value, test_job.EmployerLocation.Value, test_job.JobType.Value, test_job.JobCoreCompetency.Value), test_job.ToString());


            var testJob1 = new Job( null ,"Doggie Love", "Mars", "Dog Groomer", "Grooming");
            string testString1 = @"
            ID: {0}
            Name: Data Not Available
            Employer: {2}
            Location: {3}
            Position Type: {4}
            Core Competency: {5}
            ";
            Assert.AreEqual(string.Format(testString1, testJob1.Id, testJob1.Name, testJob1.EmployerName.Value, testJob1.EmployerLocation.Value, testJob1.JobType.Value, testJob1.JobCoreCompetency.Value), testJob1.ToString());


            var testJob2 = new Job("Groomer", null, "Mars", "Dog Groomer", "Grooming");
            string testString2 = @"
            ID: {0}
            Name: {1}
            Employer: Data Not Available
            Location: {3}
            Position Type: {4}
            Core Competency: {5}
            ";
            Assert.AreEqual(string.Format(testString2, testJob2.Id, testJob2.Name, testJob2.EmployerName.Value, testJob2.EmployerLocation.Value, testJob2.JobType.Value, testJob2.JobCoreCompetency.Value), testJob2.ToString());


            var testJob3 = new Job("Groomer", "Doggie Love", null, "Dog Groomer", "Grooming");
            string testString3 = @"
            ID: {0}
            Name: {1}
            Employer: {2}
            Location: Data Not Available
            Position Type: {4}
            Core Competency: {5}
            ";
            Assert.AreEqual(string.Format(testString3, testJob3.Id, testJob3.Name, testJob3.EmployerName.Value, testJob3.EmployerLocation.Value, testJob3.JobType.Value, testJob3.JobCoreCompetency.Value), testJob3.ToString());
             

            var testJob4 = new Job("Groomer", "Doggie Love", "Mars", null, "Grooming");
            string testString4 = @"
            ID: {0}
            Name: {1}
            Employer: {2}
            Location: {3}
            Position Type: Data Not Available
            Core Competency: {5}
            ";
            Assert.AreEqual(string.Format(testString4, testJob4.Id, testJob4.Name, testJob4.EmployerName.Value, testJob4.EmployerLocation.Value, testJob4.JobType.Value, testJob4.JobCoreCompetency.Value), testJob4.ToString());


            var testJob5 = new Job("Groomer", "Doggie Love", "Mars", "Dog Groomer", null);
            string testString5 = @"
            ID: {0}
            Name: {1}
            Employer: {2}
            Location: {3}
            Position Type: {4}
            Core Competency: Data Not Available
            ";
            Assert.AreEqual(string.Format(testString5, testJob5.Id, testJob5.Name, testJob5.EmployerName.Value, testJob5.EmployerLocation.Value, testJob5.JobType.Value, testJob5.JobCoreCompetency.Value), testJob5.ToString());


        }
    }
}
