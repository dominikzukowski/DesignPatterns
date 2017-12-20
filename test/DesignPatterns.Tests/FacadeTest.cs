using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Facade;
namespace DesignPatterns.Tests
{
    [TestClass]
    public class FacadeTest
    {

        [TestMethod]
        public void BeginCourseInFacade()
        {
            School schoolFacade = new School();
            schoolFacade.BeginCourse();
            Assert.AreEqual("Course is started.", schoolFacade.CourseStatus);
        }
    }
}
