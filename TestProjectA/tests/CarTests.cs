using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.entity;
using System;

namespace Project.Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Car_AddPassenger_WithinSeatLimit()
        {
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 0, 0);
            Assert.IsTrue(car.AddPassenger(new Passenger("Alice", 25)));
        }

        [TestMethod]
        public void Car_AddPassenger_ExceedSeatLimit()
        {
            var car = new Car("Car1", 200, 1, new Driver("John", 30), 0, 0);
            car.AddPassenger(new Passenger("Alice", 25));
            Assert.IsFalse(car.AddPassenger(new Passenger("Bob", 28)));
        }

        [TestMethod]
        public void Car_RemovePassenger()
        {
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 0, 0);
            car.AddPassenger(new Passenger("Alice", 25));
            car.RemovePassenger("Alice");
            Assert.AreEqual(0, car.Passengers.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Car_MoveToInvalidPosition()
        {
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 0, 0);
            car.Move(-1, -1);
        }
    }
}
