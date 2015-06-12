using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.Strategy.Animals;

namespace Test.TDD.BehavioralPatterns.Strategy
{
    [TestClass]
    public class BirdTest
    {
        [TestMethod, TestCategory("Strategy")]
        public void Validate_Number_Of_Legs_Penguin()
        {
            int expectedNumberOfLegs = 2;
            Animal penguin = new Penguin();
            Assert.AreEqual(expectedNumberOfLegs, penguin.GetNumberOfLegs());
        }
    }
}
