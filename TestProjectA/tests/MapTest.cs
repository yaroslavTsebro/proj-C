using Project.entity;

namespace TestProjectA.tests
{
    [TestClass]
    public class MapTests
    {
        [TestMethod]
        public void Map_AddCar_ValidPosition()
        {
            var map = new Map(10, 10);
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 0, 0);
            Assert.IsTrue(map.AddCar(car));
        }

        [TestMethod]
        public void Map_AddCar_InvalidPosition()
        {
            var map = new Map(10, 10);
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 11, 11);
            Assert.IsFalse(map.AddCar(car));
        }

        [TestMethod]
        public void Map_GetCar_AtPosition()
        {
            var map = new Map(10, 10);
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 5, 5);
            map.AddCar(car);
            Assert.AreEqual(car, map.GetCar(5, 5));
        }

        [TestMethod]
        public void Map_MoveCar_ValidMovement()
        {
            var map = new Map(10, 10);
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 0, 0);
            map.AddCar(car);
            Assert.IsTrue(map.MoveCar(car, 1, 1));
        }

        [TestMethod]
        public void Map_MoveCar_InvalidMovement()
        {
            var map = new Map(10, 10);
            var car = new Car("Car1", 200, 2, new Driver("John", 30), 0, 0);
            map.AddCar(car);
            Assert.IsFalse(map.MoveCar(car, 11, 11));   
        }
    }
}