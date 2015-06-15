using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.OOP.Polimorfism.Vehicles;

namespace DesignPatterns.Test.TDD.ConceptsOOP.Polimorfism
{
    [TestClass]
    public class CarTest
    {
        [TestMethod]
        [TestCategory("Polimorfism")]
        public void Validate_Move_Car()
        {
            var expectedMove = "I move like a car...";

            var car = new Car();
            var move = car.Move();

            Assert.AreEqual(expectedMove, move);
        }
    }
}
