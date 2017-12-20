using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.Prototype;
namespace DesignPatterns.Tests
{

    [TestClass]
    public class PrototypeTest
    {
        [TestMethod]
        public void CopyStudentChangeAddress()
        {
            StudentPrototype youngStudent = new StudentPrototype();
            youngStudent.Age = 15;
            youngStudent.Name = "John";
            youngStudent._Address.Street = "Street";

            StudentPrototype oldStudent = (StudentPrototype)youngStudent.Clone();
            oldStudent.Age = 70;
            oldStudent._Address.Street = "Avenue";

            Assert.AreEqual("Street", youngStudent._Address.Street);
            Assert.AreEqual("Avenue", oldStudent._Address.Street);

        }
    }
}
