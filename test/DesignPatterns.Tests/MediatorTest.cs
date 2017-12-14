using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Mediator;
namespace DesignPatterns.Tests
{
    [TestClass]
    public class MediatorTest
    {
        [TestMethod]
        public void StartTestByTeacherTest()
        {
            Mediator.Mediator mediator = new Mediator.Mediator();
            Teacher teacher = new Teacher(mediator);
            Course course = new Course(mediator);

            Assert.IsNull(course.test);

            teacher.BeginTest();

            Assert.AreEqual("Test trwa", course.test);
        }
    }
}
