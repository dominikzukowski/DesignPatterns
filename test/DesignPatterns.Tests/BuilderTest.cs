using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Builder;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class BuilderTest
    {
        [TestMethod]
        public void IsCourseNotNullTest()
        {
            CourseBuilder builder = new EnglishCourseBuilder();

            builder.NewCourse();

            Assert.IsNotNull(builder.GetCourse());
        }

        [TestMethod]
        public void EnglishLanguageTest()
        {
            LanguageSchoolDirector school = new LanguageSchoolDirector(new EnglishCourseBuilder());
            school.BeginCourse();
            Assert.AreEqual("English", school.GetCourse().Language);
            Assert.AreEqual(2, school.GetCourse().CourseBooks.Count);
            Assert.AreEqual(1200, school.GetCourse().Price);
        }

        [TestMethod]
        public void EsperantoLanguageTest()
        {
            LanguageSchoolDirector school = new LanguageSchoolDirector(new EsperantoCourseBuilder());
            school.BeginCourse();
            Assert.AreEqual("Esperanto", school.GetCourse().Language);
            Assert.AreEqual(1, school.GetCourse().CourseBooks.Count);
            Assert.AreEqual(900, school.GetCourse().Price);
        }
    }
}
