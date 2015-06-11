using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.Strategy.Animals;

namespace DesignPatterns.Test.TDD.BehavioralPatterns.Strategy
{
    [TestClass]
    public class BirdTest
    {
        [TestMethod]
        [TestCategory("Strategy")]
        public void Validate_Number_Of_Legs_Penguin()
        {
            Animal penguin = new Penguin();
            Assert.AreEqual(2, penguin.GetNumberOfLegs());
        }
    }
}
