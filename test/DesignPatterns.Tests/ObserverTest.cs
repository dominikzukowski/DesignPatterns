using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.LanguageSchool;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class ObserverTest
    {
        [TestMethod]
        public void ObserverIsStudentsDoingExcercise()
        {
            Teacher teacher = new Teacher();
            Student student = new Student();
            Student student2 = new Student();

            teacher.addStudent(student);
            teacher.addStudent(student2);
            teacher.BeginExcercise();

            Assert.IsTrue(student.IsDoingExcercise);
            Assert.IsTrue(student2.IsDoingExcercise);
        }
    }
}
