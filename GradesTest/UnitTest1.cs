using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GradesTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestInitialize]
        public void Init()
        {
            GradesPrototype.Data.DataSource.CreateData(); // First add the solution to references in the GradesTest solution. Access it by referring the solutionname you want to use.
        }

        [TestMethod]
        public void TestValidGrade()
        {
            GradesPrototype.Data.Grade gradetest = new GradesPrototype.Data.Grade(5, "11/5/2000", "History", "B+", "Hitler was not a good person");
            Assert.AreEqual(gradetest.StudentID, 5);
            Assert.AreEqual(gradetest.AssessmentDate, "11/05/2000");
            Assert.AreEqual(gradetest.SubjectName, "History");
            Assert.AreEqual(gradetest.Assessment, "B+");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBadDate()
        {
            GradesPrototype.Data.Grade wrongdatetest = new GradesPrototype.Data.Grade(3, "1/1/5000", "History", "A", "Aye niggau");
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestDateNotReconized()
        {
            GradesPrototype.Data.Grade nonDate = new GradesPrototype.Data.Grade(2, "200/200/200", "Math", "C-", "mapff");

        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestBadAssessment()
        {
            GradesPrototype.Data.Grade testGrade = new GradesPrototype.Data.Grade();
            testGrade.Assessment = "T";
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestBadSubject()
        {
            GradesPrototype.Data.Grade testSubject = new GradesPrototype.Data.Grade();
            testSubject.SubjectName = "German";
        }
    }
}

