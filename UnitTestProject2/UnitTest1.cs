using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addYtoXTestMethod()
        {
            //Arrange
            int x = 40;
            int y = 50;
            int expectedResult = 90;

            //Act
            int result = Program.addYtoX(ref x, ref y);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}
