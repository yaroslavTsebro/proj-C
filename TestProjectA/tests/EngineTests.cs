using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project.entity;
using System;

namespace Project.Tests
{
    [TestClass]
    public class EngineTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Engine_NegativePerformance_ThrowsException()
        {
            var engine = new Engine(-100);
        }

        [TestMethod]
        public void Engine_ValidRange_AssignedCorrectly()
        {
            var engine = new Engine(600);
            Assert.AreEqual(2, engine.Range);
        }

        [TestMethod]
        public void Engine_PerformanceInRangeOne()
        {
            var engine = new Engine(400);
            Assert.AreEqual(1, engine.Range);
        }
    }
}
