using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.LanguageSchool;
namespace DesignPatterns.Tests
{
    [TestClass]
    public class StrategyTest
    {
        [TestMethod]
        public void TestFullTimeCourseAddress()
        {
            var course = new Course(new FullTimeCourse());

            course.SetAddress();

            Assert.AreEqual("Warsaw, Al. Jerozolimskie 1", course.Address);
        }
    }
}
