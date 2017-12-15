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
        public void TestMethod1()
        {
            School schoolFacade = new School();
            schoolFacade.BeginCourse();
            var dupa = schoolFacade.CourseStatus;
            Assert.AreEqual("Course is started.", schoolFacade.CourseStatus);
        }


    }
}
