using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.LanguageSchool;
using DesignPatterns.Factory;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class FactoryTest
    {
        [TestMethod]
        public void SimpleFactoryTest()
        {
            Course course = new Course();
            course.Type = SimpleFactory.CreateClassrom(CourseType.Online);
            Assert.IsInstanceOfType(course.Type, typeof(OnlineCourse));
        }

        [TestMethod]
        public void FactoryMethodTest()
        {
            Course course = new Course();
            IFactoryMethod factory = new FullTimeCourseFactory();
            course.Type = factory.CreateClassrom();
            Assert.IsInstanceOfType(course.Type, typeof(FullTimeCourse));
        }
    }
}
