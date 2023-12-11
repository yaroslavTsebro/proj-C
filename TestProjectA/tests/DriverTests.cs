using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.entity;
using System;

namespace Project.Tests
{
    [TestClass]
    public class DriverTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Driver_InvalidName_ThrowsException()
        {
            var driver = new Driver("Jo", 30); // Name too short
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Driver_InvalidAge_ThrowsException()
        {
            var driver = new Driver("John", -1); // Negative age
        }

        [TestMethod]
        public void Driver_ValidData_CreatesInstance()
        {
            var driver = new Driver("John", 30);
            Assert.AreEqual("John", driver.Name);
            Assert.AreEqual(30, driver.Age);
        }
    }
}
