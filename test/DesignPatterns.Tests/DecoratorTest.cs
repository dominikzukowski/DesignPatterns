using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Decorator;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class DecoratorTest
    {
        [TestMethod]
        public void StandardCourseDescptionTest()
        {
            ICourse course = new Course();
            var description = course.GetDescription();
            Assert.AreEqual("Language Course", description);
        }

        [TestMethod]
        public void GroupCourseDescriptionTest()
        {
            ICourse course = new Course();
            course = new GroupCourseDecorator(course);

            var description = course.GetDescription();
            Assert.AreEqual("Group Language Course", description);
        }

        [TestMethod]
        public void PropertyDescriptionTest()
        {
            ICourse course = new OnlineCourseDecorator(new GroupCourseDecorator(new Course()));
            course.BeginCourse();
            var description = course.Description;
            Assert.AreEqual("Online Group Language Course", description);
        }
    }
}
