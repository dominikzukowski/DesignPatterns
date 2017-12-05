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
    }
}
