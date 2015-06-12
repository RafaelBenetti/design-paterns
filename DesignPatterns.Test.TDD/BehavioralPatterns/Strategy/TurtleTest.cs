using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.Strategy.Animals;

namespace Test.TDD.BehavioralPatterns.Strategy
{
    [TestClass]
    public class TurtleTest
    {
        [TestMethod]
        [TestCategory("Strategy")]
        public void Validate_Number_Of_Legs_Turtle()
        {
            Animal turtle = new Turtle();
            Assert.AreEqual(7, turtle.GetNumberOfLegs());
        }
    }
}
