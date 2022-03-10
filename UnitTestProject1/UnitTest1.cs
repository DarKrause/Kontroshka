using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 4;
            ClassLibrary1.Study.Student student = new ClassLibrary1.Study.Student("Мещанов Вадим Сергеевич", 1281, 2018);
            string[] marks = new string[2] { "4", "5" };
            double actual = student.MinAVG(marks);
            Assert.AreEqual(expected, actual);
        }
    }
}
