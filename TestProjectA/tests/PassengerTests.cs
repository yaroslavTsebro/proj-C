using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.entity;
using System;

namespace Project.Tests
{
    [TestClass]
    public class PassengerTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Passenger_InvalidName_ThrowsException()
        {
            var passenger = new Passenger("Al", 25);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Passenger_InvalidAge_ThrowsException()
        {
            var passenger = new Passenger("Alice", -5);
        }

        [TestMethod]
        public void Passenger_ValidData_CreatesInstance()
        {
            var passenger = new Passenger("Alice", 25);
            Assert.AreEqual("Alice", passenger.Name);
            Assert.AreEqual(25, passenger.Age);
        }
    }
}
