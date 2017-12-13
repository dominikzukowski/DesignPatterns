using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.LanguageSchool;
using DesignPatterns.Factory;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class AbstractFactoryTest
    {
        [TestMethod]
        public void OnlineAbstractFactoryTest()
        {
            var factory = new OnlineCourseAbstractFactory();
            var course = new CourseAbstractFactory(factory);

            course.BeginCourse();

            Assert.IsInstanceOfType(course.courseType, typeof(OnlineCourse));
        }

        [TestMethod]
        public void FullTimeAbstractFactoryTest()
        {
            var factory = new FullTimeCourseAbstractFactory();
            var course = new CourseAbstractFactory(factory);

            course.BeginCourse();

            Assert.IsInstanceOfType(course.courseType, typeof(FullTimeCourse));
        }
    }
}
