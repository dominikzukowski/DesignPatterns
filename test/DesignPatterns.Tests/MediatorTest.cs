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

            Assert.AreEqual("The test is in progress.", course.test);
        }

        [TestMethod]
        public void GetCourseLevelTest()
        {
            Mediator.Mediator mediator = new Mediator.Mediator();
            Teacher teacher = new Teacher(mediator);
            Course course = new Course(mediator);

            var courseLevel = teacher.GetCourseLevel();

            Assert.AreEqual("B2", courseLevel);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ExceptionTest()
        {
            Mediator.Mediator mediator = new Mediator.Mediator();
            
            mediator.Register<string>("Course Level test", null);
            mediator.Register<string>("Course Level test", null);
        }
    }
}
