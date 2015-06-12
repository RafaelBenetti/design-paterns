using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPatterns.BehavioralPatterns.Strategy.Animals;

namespace Test.TDD.BehavioralPatterns.Strategy
{
    [TestClass]
    public class SpiderTest
    {
        [TestMethod, TestCategory("Strategy")]
        public void Validate_Number_Of_Legs_Spider()
        {
            int expectedNumberOfLegs = 8;
            Animal spider = new Spider();
            Assert.AreEqual(expectedNumberOfLegs, spider.GetNumberOfLegs());
        }
    }
}
