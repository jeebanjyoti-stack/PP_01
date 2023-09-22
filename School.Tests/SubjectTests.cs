using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Tests
{
    [TestFixture]
    public class SubjectTests
    {
        [Test]
        public void TestSubjectName()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Name = "Math";

            // Act
            string subjectName = subject.Name;

            // Assert
            Assert.AreEqual("Math", subjectName);
        }

        [Test]
        public void TestSubjectId()
        {
            // Arrange
            Subject subject = new Subject();
            subject.Id = 2;

            // Act
            int subjectId = subject.Id;

            // Assert
            Assert.AreEqual(2, subjectId);
        }
    }
}
